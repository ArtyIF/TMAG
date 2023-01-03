[CreateNodeMenu("TMAG/Operators/Math/Maximum")]
public class MaximumNode : TMAGTwoInputComputeShaderNodeBase
{
    protected override string KernelName { get; } = "MaximumNodeMain";
    protected override string NodeName { get; } = "Maximum";
}