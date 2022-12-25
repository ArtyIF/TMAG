[CreateNodeMenu("TMAG/Operators/Math/Subtract")]
public class SubtractNode : TMAGTwoInputComputeShaderNodeBase
{
    protected override string KernelName { get; } = "SubtractNodeMain";
    protected override string NodeName { get; } = "Subtract";
}