using System;
using UnityEngine;
using XNode;

public class TMAGShaderNodeBase : TMAGNodeBase
{
    [Output(typeConstraint = TypeConstraint.Strict)] public CustomRenderTexture output;

    protected Material ShaderMaterial { get; private set; }
    protected virtual string ShaderPath { get; }

    protected override void Init()
    {
        base.Init();
        ShaderMaterial = new Material(Shader.Find(ShaderPath));
        if ((graph as TMAGGraph).terrainResolution < 1)
        {
            throw new InvalidOperationException("Terrain resolution is negative or 0!");
        }
        output = new CustomRenderTexture((graph as TMAGGraph).terrainResolution, (graph as TMAGGraph).terrainResolution, RenderTextureFormat.R16, RenderTextureReadWrite.Linear)
        {
            initializationSource = CustomRenderTextureInitializationSource.Material,
            material = ShaderMaterial,
            initializationMaterial = ShaderMaterial,
            initializationMode = CustomRenderTextureUpdateMode.OnDemand,
            updateMode = CustomRenderTextureUpdateMode.OnDemand,
            graphicsFormat = UnityEngine.Experimental.Rendering.GraphicsFormat.R16_UNorm,
            depthStencilFormat = UnityEngine.Experimental.Rendering.GraphicsFormat.None
        };
        SetShaderVariables();
        output.Initialize();
        output.Update();
    }

    protected virtual void SetShaderVariables() { }

    public override object GetValue(NodePort port)
    {
        if (ShaderMaterial == null || output == null) {
            Init();
        }

        if ((graph as TMAGGraph).terrainResolution != output.width) {
            Init();
        }

        if (port.fieldName == "output")
        {
            SetShaderVariables();
            output.Update();
            return output;
        }
        return null;
    }
}