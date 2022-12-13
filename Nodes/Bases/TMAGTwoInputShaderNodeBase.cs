using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNode;

public class TMAGTwoInputShaderNodeBase : TMAGShaderNodeBase
{
    [Input(connectionType = ConnectionType.Override, typeConstraint = TypeConstraint.Strict)] public CustomRenderTexture a;
    [Input(connectionType = ConnectionType.Override, typeConstraint = TypeConstraint.Strict)] public CustomRenderTexture b;

    protected override void SetShaderVariables()
    {
        ShaderMaterial.SetTexture("_Input_A", GetInputValue("a", a));
        ShaderMaterial.SetTexture("_Input_B", GetInputValue("b", b));
    }
}