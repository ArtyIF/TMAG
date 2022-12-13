using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNode;

public class TMAGOneInputShaderNodeBase : TMAGShaderNodeBase
{
    [Input(connectionType = ConnectionType.Override, typeConstraint = TypeConstraint.Strict)] public CustomRenderTexture input;

    protected override void SetShaderVariables()
    {
        ShaderMaterial.SetTexture("_Input", GetInputValue("input", input));
    }
}