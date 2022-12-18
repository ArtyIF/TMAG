using UnityEngine;

[CreateNodeMenu("TMAG/Generators/Import/Texture")]
public class TextureNode : TMAGShaderNodeBase
{
    public Texture2D value;
    protected override string ShaderPath { get; } = "Hidden/TMAG/Blit";
    protected override string NodeName { get; } = "Texture";

    protected override void SetShaderVariables()
    {
        ShaderMaterial.SetTexture("_Input", GetInputValue("value", value));
    }
}