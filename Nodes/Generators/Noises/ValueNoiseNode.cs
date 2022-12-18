[CreateNodeMenu("TMAG/Generators/Noise/Value")]
public class ValueNoiseNode : TMAGShaderNodeBase
{
    public float scale = 10.0f;
    protected override string ShaderPath { get; } = "Hidden/TMAG/ValueNoiseNode";
    protected override string NodeName { get; } = "Value Noise";

    protected override void SetShaderVariables()
    {
        ShaderMaterial.SetFloat("_Scale", GetInputValue("scale", scale));
    }
}