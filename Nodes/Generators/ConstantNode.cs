[CreateNodeMenu("TMAG/Generators/Constant")]
public class ConstantNode : TMAGComputeShaderNodeBase
{
    public float value;
    protected override string KernelName { get; } = "ConstantNodeMain";
    protected override string NodeName { get; } = "Constant";

    protected override void SetShaderVariables()
    {
        base.SetShaderVariables();
        ComputeShaderInstance.SetFloat("Value", value);
    }

    protected new void Reset() {
        base.Reset();
        hidePreview = true;
    }
}