using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNode;

[CreateNodeMenu("TMAG/Generators/Noise/Value")]
public class ValueNoiseNode : TMAGShaderNodeBase
{
    public float scale;
    protected override string ShaderPath { get; } = "Hidden/TMAG/ValueNoiseNode";
    protected override string NodeName { get; } = "Value Noise";

    protected override void SetShaderVariables()
    {
        ShaderMaterial.SetFloat("_Scale", GetInputValue("scale", scale));
    }
}