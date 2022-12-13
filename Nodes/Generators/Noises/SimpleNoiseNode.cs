using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNode;

[CreateNodeMenu("TMAG/Generators/Noise/Simple")]
public class SimpleNoiseNode : TMAGShaderNodeBase
{
    public float scale;
    protected override string ShaderPath { get; } = "Hidden/TMAG/SimpleNoiseNode";
    protected override string NodeName { get; } = "Simple Noise";

    protected override void SetShaderVariables()
    {
        ShaderMaterial.SetFloat("_Scale", GetInputValue("scale", scale));
    }
}