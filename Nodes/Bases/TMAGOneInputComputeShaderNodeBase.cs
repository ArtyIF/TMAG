using UnityEngine;

public class TMAGOneInputComputeShaderNodeBase : TMAGComputeShaderNodeBase
{
    [Input(
        connectionType = ConnectionType.Override,
        typeConstraint = TypeConstraint.Strict,
        backingValue = ShowBackingValue.Never
    )]
    public RenderTexture input;

    protected override bool AllTexturesAreNotNull()
    {
        RenderTexture inputValue = GetInputValue<RenderTexture>("input");
        return base.AllTexturesAreNotNull() && inputValue;
    }

    protected override void SetShaderVariables()
    {
        base.SetShaderVariables();
        if (AllTexturesAreNotNull()) {
            ComputeShader.SetTexture(KernelIndex, "Input", GetInputValue<RenderTexture>("input"));
        }
    }
}