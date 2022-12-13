using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNode;

[CreateNodeMenu("TMAG/Outputs/Heightmap")]
public class HeightmapNode : TMAGOneInputShaderNodeBase
{
    protected override string ShaderPath { get; } = "Hidden/TMAG/Blit";
    protected override string NodeName { get; } = "Heightmap";
}