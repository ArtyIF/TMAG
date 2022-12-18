[CreateNodeMenu("TMAG/Generators/Noise/Simplex")]
public class SimplexNoiseNode : TMAGShaderNodeBase
{
    public float scale = 10.0f;
    protected override string ShaderPath { get; } = "Hidden/TMAG/SimplexNoiseNode";
    protected override string NodeName { get; } = "Simplex Noise";

    protected override void SetShaderVariables()
    {
        ShaderMaterial.SetFloat("_Scale", GetInputValue("scale", scale));
    }
}