using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNode;

public class TMAGTwoInputShaderNodeBase : TMAGShaderNodeBase
{
    [Input(
        connectionType = ConnectionType.Override,
        typeConstraint = TypeConstraint.Strict,
        backingValue = ShowBackingValue.Never
    )]
    public CustomRenderTexture a;
    [Input(
        connectionType = ConnectionType.Override,
        typeConstraint = TypeConstraint.Strict,
        backingValue = ShowBackingValue.Never
    )]
    public CustomRenderTexture b;

    protected override void SetShaderVariables()
    {
        ShaderMaterial.SetTexture("_Input_A", GetInputValue<CustomRenderTexture>("a"));
        ShaderMaterial.SetTexture("_Input_B", GetInputValue<CustomRenderTexture>("b"));
    }
}