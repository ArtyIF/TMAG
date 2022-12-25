[CreateNodeMenu("TMAG/Operators/Math/Multiply")]
public class MultiplyNode : TMAGTwoInputComputeShaderNodeBase
{
    protected override string KernelName { get; } = "MultiplyNodeMain";
    protected override string NodeName { get; } = "Multiply";
}