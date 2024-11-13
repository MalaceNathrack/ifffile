base = "Data/"
binary = "Binary/"
compile = "CompiledShaders/"
script = "Scripts/"
shader = "Shaders/"
texture = "Textures/"

return {
    Base = {
		Paths = {
			base = base,
			binary = binary,
			compile = compile,
			script = script,
			shader = shader,
			texture = texture,
		},
	},
	
	Shared = require(base .. script .. "Config/shared"),
	SWG = dofile(base .. script .. "Config/swg.lua"),
	SIE = dofile(base .. script .. "Config/sie.lua"),
	SWB = dofile(base .. script .. "Config/swb.lua"),
	Graphics = dofile(base .. script .. "Config/graphics.lua"),
}