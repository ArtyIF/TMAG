using UnityEngine;

public class TMAGTwoInputComputeShaderNodeBase : TMAGComputeShaderNodeBase
{
    [Input(
        connectionType = ConnectionType.Override,
        typeConstraint = TypeConstraint.Strict,
        backingValue = ShowBackingValue.Never
    )]
    public RenderTexture a;
    [Input(
        connectionType = ConnectionType.Override,
        typeConstraint = TypeConstraint.Strict,
        backingValue = ShowBackingValue.Never
    )]
    public RenderTexture b;

    protected override void SetShaderVariables()
    {
        base.SetShaderVariables();
        RenderTexture inputAValue = GetInputValue<RenderTexture>("a");
        RenderTexture inputBValue = GetInputValue<RenderTexture>("b");
        if (inputAValue && inputBValue) {
            ComputeShader.SetTexture(KernelIndex, "InputA", inputAValue);
            ComputeShader.SetTexture(KernelIndex, "InputB", inputBValue);
        }
    }
}