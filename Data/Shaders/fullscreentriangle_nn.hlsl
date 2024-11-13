#include "lighting.hlsl"

struct PsIn 
{
	float4 position: SV_Position;
	float2 texCoord: TexCoord;
};

PsIn VS(uint VertexID: SV_VertexID)
{
	PsIn Out = (PsIn)0;

	float2 grid = float2((VertexID << 1) & 2, VertexID & 2);
	Out.position = float4(grid * float2(2.0f, -2.0f) + float2(-1.0f, 1.0f), 1.0f, 1.0f);

	Out.texCoord = (Out.position.xy * float2(0.5, -0.5) + 0.5);
	Out.texCoord.y *= gExtrudeAmt;

	return Out;
}

Texture2D <float4> Base : register (T2D_FSTRI_DIFFUSE);
SamplerState filter : register (SS_CLAMP_POINT);

float4 PS(PsIn In) : SV_Target 
{
	float4 base = Base.Sample(filter, In.texCoord);
	return base;
}
