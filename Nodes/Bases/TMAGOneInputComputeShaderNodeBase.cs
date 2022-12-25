using UnityEngine;

public class TMAGOneInputComputeShaderNodeBase : TMAGComputeShaderNodeBase
{
    [Input(
        connectionType = ConnectionType.Override,
        typeConstraint = TypeConstraint.Strict,
        backingValue = ShowBackingValue.Never
    )]
    public RenderTexture input;

    protected override void SetShaderVariables()
    {
        base.SetShaderVariables();
        RenderTexture inputValue = GetInputValue<RenderTexture>("input");
        if (inputValue) {
            ComputeShader.SetTexture(KernelIndex, "Input", inputValue);
        }
    }
}