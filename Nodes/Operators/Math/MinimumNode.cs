[CreateNodeMenu("TMAG/Operators/Math/Minimum")]
public class MinimumNode : TMAGTwoInputComputeShaderNodeBase
{
    protected override string KernelName { get; } = "MinimumNodeMain";
    protected override string NodeName { get; } = "Minimum";
}