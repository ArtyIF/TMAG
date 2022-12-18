[CreateNodeMenu("TMAG/Generators/Noise/Perlin")]
public class PerlinNoiseNode : TMAGShaderNodeBase
{
    public float scale = 10.0f;
    protected override string ShaderPath { get; } = "Hidden/TMAG/PerlinNoiseNode";
    protected override string NodeName { get; } = "Perlin Noise";

    protected override void SetShaderVariables()
    {
        ShaderMaterial.SetFloat("_Scale", GetInputValue("scale", scale));
    }
}