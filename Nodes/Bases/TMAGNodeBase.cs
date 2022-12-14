using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNode;

public class TMAGNodeBase : Node
{
    protected virtual string NodeName { get; }

    protected void Reset()
    {
        name = NodeName;
    }
}