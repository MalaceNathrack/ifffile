struct Material
{
	float4   diffuse;
	float4   ambient;
	float4   specular;
	float4   emissive;
	float    specularPower;
};

struct AmbientLight
{
	float4   ambientColor;
};

struct ParallelSpecularLight
{
	float3   direction_w;
	float4   diffuseColor;
	float4   specularColor;
};

struct ParallelLight
{
	float3   direction_w;
	float4   diffuseColor;
};

struct PointSpecularLight
{
	float3   position_w;
	float4   diffuseColor;
	float4   attenuation;
	float4   specularColor;
};

struct PointLight
{
	float3   position_w;
	float4   diffuseColor;
	float4   attenuation;
};

struct Dot3Light
{
	float3   cameraPosition_o;
	float3   direction_o;
	float4   diffuseColor;
	float4   specularColor;
};

struct DiffuseSpecular
{
	float4	diffuse;
	float4	specular;
};

static const int NumberOfParallelSpecularLights = 1;
static const int NumberOfParallelLights         = 2;
static const int NumberOfPointSpecularLights    = 1;
static const int NumberOfPointLights            = 4;
static const int NumberOfDot3Lights             = 1;

struct LightData
{
	AmbientLight           ambient;
	ParallelSpecularLight  parallelSpecular[NumberOfParallelSpecularLights];
	ParallelLight          parallel[NumberOfParallelLights];
	PointSpecularLight     pointSpecular[NumberOfPointSpecularLights];
	PointLight             points[NumberOfPointLights];
	Dot3Light              dot3[NumberOfDot3Lights];
};

cbuffer ChangedEachFrame : register(CB_EACH_FRAME)
{
	row_major matrix gView				: packoffset(c0);
	row_major matrix gViewInv			: packoffset(c4);
	row_major matrix gProjection		: packoffset(c8);
	row_major matrix gViewProjection	: packoffset(c12);
	float4 gFog							: packoffset(c16);
	float3 gCameraPosition				: packoffset(c17.x);
	float gGameTime						: packoffset(c17.w);
	float3 gLightDirection				: packoffset(c18); 	
	float4 gSkyProperties				: packoffset(c19); // gSunLightness, gSunRadiusAttenuation, gHazeTopAltitude, gOffset
	float4 gBaseColour					: packoffset(c20);
	float4 gCloudProperties				: packoffset(c21); 	// CloudSize, CloudOpacity, CloudTranslation[2]
	float  gExtrudeBias					: packoffset(c22.x);
	float  gExtrudeAmt					: packoffset(c22.y);
	LightData lightData					: packoffset(c23);	
};

cbuffer ChangesManyPerFrame : register(CB_MANY_PER_FRAME)
{
	row_major matrix gWorld				: packoffset(c0);
	float2 gTexOffset					: packoffset(c4.x);
	float gEnvBlend						: packoffset(c4.z);
	float gSkyBaseAmount				: packoffset(c4.w);
	Material gMaterial					: packoffset(c5.x);
};

float lengthSquared(float3 v)
{
	return dot(v, v);
}

float4 calculateDiffuseParallelLight(ParallelLight light, float3 vertexNormal_o)
{
	float3 normal_w = normalize(mul(vertexNormal_o, (float3x3)gWorld));
	return max(dot(normal_w, light.direction_w), 0.0) * light.diffuseColor;
}

float4 calculateDiffusePointLight(PointLight light, float4 vertexPosition_o, float3 vertexNormal_o)
{
	float3 vertexPosition_w = mul(vertexPosition_o, gWorld).xyz;
	float3 normal_w = normalize(mul(vertexNormal_o, (float3x3)gWorld));

	// Get light direction
	float3 lightDirection = light.position_w - vertexPosition_w;

	// Get light distance squared.
	float lightDistanceSquared = lengthSquared(lightDirection);

	// Get 1/lightDistance
	float oneOverLightDistance = rsqrt(lightDistanceSquared);

	// Normalize light direction
	lightDirection *= oneOverLightDistance;

	// compute distance attenuation
	float4 attenuationFactors;
	attenuationFactors.x = 1.0;
	attenuationFactors.y = lightDistanceSquared * oneOverLightDistance;
	attenuationFactors.z = lightDistanceSquared;
	attenuationFactors.w = oneOverLightDistance;
	float distanceAttenuation = 1.0 / dot(light.attenuation, attenuationFactors);

	return max(dot(normal_w, lightDirection), 0.0) * distanceAttenuation * light.diffuseColor;
}

float4 calculateDiffuseLighting(bool dot3, float4 vertexPosition_o, float3 vertexNormal_o)
{
	float4 result = float4(0,0,0,0); //material.emissiveColor;

	if (!dot3)
		result += calculateDiffuseParallelLight((ParallelLight)lightData.parallelSpecular[0], vertexNormal_o);

	result += calculateDiffuseParallelLight(lightData.parallel[0], vertexNormal_o);
	result += calculateDiffuseParallelLight(lightData.parallel[1], vertexNormal_o);

	//result += calculateDiffusePointLight((PointLight)lightData.pointSpecular[0], vertexPosition_o, vertexNormal_o);
	//result += calculateDiffusePointLight(lightData.points[0], vertexPosition_o, vertexNormal_o);
	//result += calculateDiffusePointLight(lightData.points[1], vertexPosition_o, vertexNormal_o);
	//result += calculateDiffusePointLight(lightData.points[2], vertexPosition_o, vertexNormal_o);
	//result += calculateDiffusePointLight(lightData.points[3], vertexPosition_o, vertexNormal_o);

	return result;
}

float3 signAndBias(float3 v)
{
	return (v - 0.5) * 2.0;
}

float3 reverseSignAndBias(float3 v)
{
	return (v * 0.5) + 0.5;
}

float3 transformTerrainDot3LightDirection(float3 vertexNormal_o)
{
	float3 j = cross(vertexNormal_o, float3(1.0f, 0.0f, 0.0f));
	float3 i = cross(j, vertexNormal_o);

	float3 result;
	result.x = dot(i, lightData.dot3[0].direction_o);
	result.y = dot(j, lightData.dot3[0].direction_o);
	result.z = dot(vertexNormal_o, lightData.dot3[0].direction_o);

	return reverseSignAndBias(result);
}

float calculateFog(float4 vertexPosition_o)
{
	float3 position_w = mul(vertexPosition_o, gWorld).xyz;
	float  viewerDistanceSquared = lengthSquared(gCameraPosition - position_w);
	return 1-(1.0 / exp(viewerDistanceSquared * gFog.w));
}

float calculateFogNoWorld(float4 vertexPosition_o)
{
	float  viewerDistanceSquared = lengthSquared(gCameraPosition - vertexPosition_o.xyz);
	return 1-(1.0 / exp(viewerDistanceSquared * gFog.w));
}