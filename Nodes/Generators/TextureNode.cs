using UnityEngine;

[CreateNodeMenu("TMAG/Generators/Texture")]
public class TextureNode : TMAGComputeShaderNodeBase
{
    public Texture2D value;
    protected override string KernelName { get; } = "TextureNodeMain";
    protected override string NodeName { get; } = "Texture";

    protected override bool AllTexturesAreNotNull()
    {
        return base.AllTexturesAreNotNull() && value;
    }

    protected override void SetShaderVariables()
    {
        base.SetShaderVariables();
        if (value) {
            ComputeShader.SetTexture(KernelIndex, "Value", value);
            ComputeShader.SetFloat("ValueResolution", Mathf.Min(value.width, value.height));
        }
    }
}