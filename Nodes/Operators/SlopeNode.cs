using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNode;

[CreateNodeMenu("TMAG/Operators/Slope")]
public class SlopeNode : TMAGOneInputShaderNodeBase
{
    protected override string ShaderPath { get; } = "Hidden/TMAG/SlopeNode";
    protected override string NodeName { get; } = "Slope";
}