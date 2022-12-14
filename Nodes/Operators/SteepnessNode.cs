using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNode;

[CreateNodeMenu("TMAG/Operators/Steepness")]
public class SteepnessNode : TMAGOneInputShaderNodeBase
{
    protected override string ShaderPath { get; } = "Hidden/TMAG/SteepnessNode";
    protected override string NodeName { get; } = "Steepness";
}