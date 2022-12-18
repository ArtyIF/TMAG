using UnityEngine;

public class TMAGOneInputShaderNodeBase : TMAGShaderNodeBase
{
    [Input(
        connectionType = ConnectionType.Override,
        typeConstraint = TypeConstraint.Strict,
        backingValue = ShowBackingValue.Never
    )]
    public CustomRenderTexture input;

    protected override void SetShaderVariables()
    {
        ShaderMaterial.SetTexture("_Input", GetInputValue<CustomRenderTexture>("input"));
    }
}