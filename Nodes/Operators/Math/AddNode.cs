[CreateNodeMenu("TMAG/Operators/Math/Add")]
public class AddNode : TMAGTwoInputShaderNodeBase
{
    protected override string ShaderPath { get; } = "Hidden/TMAG/AddNode";
    protected override string NodeName { get; } = "Add";
}