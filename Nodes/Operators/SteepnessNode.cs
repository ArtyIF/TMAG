[CreateNodeMenu("TMAG/Operators/Steepness")]
public class SteepnessNode : TMAGOneInputShaderNodeBase
{
    protected override string ShaderPath { get; } = "Hidden/TMAG/SteepnessNode";
    protected override string NodeName { get; } = "Steepness";
}