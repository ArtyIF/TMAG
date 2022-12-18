[CreateNodeMenu("TMAG/Generators/Import/Constant")]
public class ConstantNode : TMAGShaderNodeBase
{
    public float value;
    public override bool HidePreview { get; set; } = true;
    protected override string ShaderPath { get; } = "Hidden/TMAG/ConstantNode";
    protected override string NodeName { get; } = "Constant";

    protected override void SetShaderVariables()
    {
        ShaderMaterial.SetFloat("_Value", GetInputValue("value", value));
    }
}