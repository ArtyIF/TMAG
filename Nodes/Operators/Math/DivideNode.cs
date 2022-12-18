[CreateNodeMenu("TMAG/Operators/Math/Divide")]
public class DivideNode : TMAGTwoInputShaderNodeBase
{
    protected override string ShaderPath { get; } = "Hidden/TMAG/DivideNode";
    protected override string NodeName { get; } = "Divide";
}