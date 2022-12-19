[CreateNodeMenu("TMAG/Generators/Import/Constant")]
public class ConstantNode : TMAGShaderNodeBase
{
    public float value;
    protected override string ShaderPath { get; } = "Hidden/TMAG/ConstantNode";
    protected override string NodeName { get; } = "Constant";

    protected override void SetShaderVariables()
    {
        ShaderMaterial.SetFloat("_Value", GetInputValue("value", value));
    }

    protected new void Reset() {
        base.Reset();
        hidePreview = true;
    }
}