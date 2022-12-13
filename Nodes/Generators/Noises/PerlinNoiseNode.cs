using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNode;

[CreateNodeMenu("TMAG/Generators/Noise/Perlin")]
public class PerlinNoiseNode : TMAGShaderNodeBase
{
    public float scale;
    protected override string ShaderPath { get; } = "Hidden/TMAG/PerlinNoiseNode";
    protected override string NodeName { get; } = "Perlin Noise";

    protected override void SetShaderVariables()
    {
        ShaderMaterial.SetFloat("_Scale", GetInputValue("scale", scale));
    }
}