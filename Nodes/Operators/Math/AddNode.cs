[CreateNodeMenu("TMAG/Operators/Math/Add")]
public class AddNode : TMAGTwoInputComputeShaderNodeBase
{
    protected override string KernelName { get; } = "AddNodeMain";
    protected override string NodeName { get; } = "Add";
}