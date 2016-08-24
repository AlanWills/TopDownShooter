#if OPENGL
	#define SV_POSITION POSITION
	#define VS_SHADERMODEL vs_3_0
	#define PS_SHADERMODEL ps_3_0
#else
	#define VS_SHADERMODEL vs_4_0_level_9_1
	#define PS_SHADERMODEL ps_4_0_level_9_1
#endif

sampler s0;
texture lightMask;
sampler lightSampler = sampler_state { Texture = <lightMask>; };
float4 ambientLight;

float4 white = float4(1, 1, 1, 1);
float4 black = float4(0, 0, 0, 1);

float4 PointLighting(float4 pos : SV_POSITION, float4 color1 : COLOR0, float2 coords : TEXCOORD0) : COLOR0
{
  float4 color = tex2D(s0, coords);
  float4 lightColour = tex2D(lightSampler, coords);
  
  lightColour = lightColour + (white - lightColour) * ambientLight;

  return color * lightColour;
}

technique SpriteDrawing
{
	pass Pass1
	{
		PixelShader = compile PS_SHADERMODEL PointLighting();
	}
};