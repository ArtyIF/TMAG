using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNode;

[CreateNodeMenu("TMAG/Generators/Noise")]
public class NoiseNode : TMAGShaderNodeBase
{
    public float scale;
    protected override string ShaderPath { get; } = "Hidden/TMAG/NoiseNode";
    protected override string NodeName { get; } = "Noise";

    protected override void SetShaderVariables()
    {
        ShaderMaterial.SetFloat("_Scale", GetInputValue("scale", scale));
    }
}