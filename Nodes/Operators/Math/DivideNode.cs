[CreateNodeMenu("TMAG/Operators/Math/Divide")]
public class DivideNode : TMAGTwoInputComputeShaderNodeBase
{
    protected override string KernelName { get; } = "DivideNodeMain";
    protected override string NodeName { get; } = "Divide";
}