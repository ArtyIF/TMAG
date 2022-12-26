using UnityEngine;

[CreateNodeMenu("TMAG/Operators/Slope")]
public class SlopeNode : TMAGOneInputComputeShaderNodeBase
{
    public Vector2 minBlendDegrees;
    public Vector2 maxBlendDegrees;
    protected override string KernelName { get; } = "SlopeNodeMain";
    protected override string NodeName { get; } = "Slope";

    protected override void SetShaderVariables()
    {
        base.SetShaderVariables();
        ComputeShaderInstance.SetVector("BlendVector", new Vector4(minBlendDegrees.x, minBlendDegrees.y, maxBlendDegrees.x, maxBlendDegrees.y) / 90.0f);
    }
}