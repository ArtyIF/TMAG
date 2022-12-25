[CreateNodeMenu("TMAG/Operators/Steepness")]
public class SteepnessNode : TMAGOneInputComputeShaderNodeBase
{
    protected override string KernelName { get; } = "SteepnessNodeMain";
    protected override string NodeName { get; } = "Steepness";
}