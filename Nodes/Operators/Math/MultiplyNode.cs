using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNode;

[CreateNodeMenu("TMAG/Operators/Math/Multiply")]
public class MultiplyNode : TMAGTwoInputShaderNodeBase
{
    protected override string ShaderPath { get; } = "Hidden/TMAG/MultiplyNode";
    protected override string NodeName { get; } = "Multiply";
}