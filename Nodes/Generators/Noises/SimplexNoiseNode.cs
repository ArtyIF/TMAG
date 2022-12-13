using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNode;

[CreateNodeMenu("TMAG/Generators/Noise/Simplex")]
public class SimplexNoiseNode : TMAGShaderNodeBase
{
    public float scale;
    protected override string ShaderPath { get; } = "Hidden/TMAG/SimplexNoiseNode";
    protected override string NodeName { get; } = "Simplex Noise";

    protected override void SetShaderVariables()
    {
        ShaderMaterial.SetFloat("_Scale", GetInputValue("scale", scale));
    }
}