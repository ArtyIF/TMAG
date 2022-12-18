using UnityEngine;

[CreateNodeMenu("TMAG/Operators/Slope")]
public class SlopeNode : TMAGOneInputShaderNodeBase
{
    public Vector2 startBlend = new(15.0f, 30.0f);
    public Vector2 endBlend = new(75.0f, 90.0f);

    protected override string ShaderPath { get; } = "Hidden/TMAG/SlopeNode";
    protected override string NodeName { get; } = "Slope";

    protected override void SetShaderVariables()
    {
        base.SetShaderVariables();
        ShaderMaterial.SetVector("_Blend_Vector", new Vector4(startBlend.x / 90.0f, startBlend.y / 90.0f, endBlend.x / 90.0f, endBlend.y / 90.0f));
    }
}