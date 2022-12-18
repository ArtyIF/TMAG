[CreateNodeMenu("TMAG/Operators/Math/Subtract")]
public class SubtractNode : TMAGTwoInputShaderNodeBase
{
    protected override string ShaderPath { get; } = "Hidden/TMAG/SubtractNode";
    protected override string NodeName { get; } = "Subtract";
}