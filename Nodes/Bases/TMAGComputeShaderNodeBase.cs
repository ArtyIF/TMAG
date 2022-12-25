using System;
using UnityEngine;
using XNode;

public class TMAGComputeShaderNodeBase : TMAGNodeBase
{
    [Output(typeConstraint = TypeConstraint.Strict)] public RenderTexture output;

    [HideInInspector] public bool hidePreview = false;
    [HideInInspector] public ComputeShader ComputeShader;
    protected virtual string KernelName { get; }
    protected int KernelIndex
    {
        get
        {
            if (ComputeShader != null)
            {
                return ComputeShader.FindKernel(KernelName);
            }
            return -1;
        }
    }

    protected override void Init()
    {
        if (!SystemInfo.supportsComputeShaders) {
            throw new PlatformNotSupportedException("TMAG requires compute shader support, which this platform doesn't have");
        }
        if (!SystemInfo.SupportsRandomWriteOnRenderTextureFormat(RenderTextureFormat.RFloat)) {
            throw new PlatformNotSupportedException("TMAG requires random write on RFloat render texture format support, which this platform doesn't have");
        }
        base.Init();
        if ((graph as TMAGGraph).terrainResolution < 1)
        {
            throw new InvalidOperationException("Terrain resolution is negative or 0!");
        }
        output = new RenderTexture((graph as TMAGGraph).terrainResolution, (graph as TMAGGraph).terrainResolution, 1, RenderTextureFormat.RFloat, RenderTextureReadWrite.Linear)
        {
            graphicsFormat = UnityEngine.Experimental.Rendering.GraphicsFormat.R32_SFloat,
            depthStencilFormat = UnityEngine.Experimental.Rendering.GraphicsFormat.None,
            enableRandomWrite = true
        };
        SetShaderVariables();
    }

    protected virtual void SetShaderVariables()
    {
        ComputeShader.SetTexture(KernelIndex, "Output", output);
        ComputeShader.SetFloat("Resolution", (graph as TMAGGraph).terrainResolution);
        ComputeShader.SetFloat("TexelSize", 1.0f / (graph as TMAGGraph).terrainResolution);
    }

    protected virtual bool AllTexturesAreNotNull()
    {
        return output;
    }

    public override object GetValue(NodePort port)
    {
        if (output == null)
        {
            Init();
        }

        if ((graph as TMAGGraph).terrainResolution != output.width)
        {
            Init();
        }

        if (port.fieldName == "output")
        {
            SetShaderVariables();
            int threadGroups = Mathf.CeilToInt((graph as TMAGGraph).terrainResolution / 8.0f);
            if (AllTexturesAreNotNull())
            {
                ComputeShader.Dispatch(KernelIndex, threadGroups, threadGroups, 1);
                return output;
            }
        }
        return null;
    }
}