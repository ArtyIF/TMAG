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

    protected override bool AllTexturesAreNotNull()
    {
        RenderTexture inputAValue = GetInputValue<RenderTexture>("a");
        RenderTexture inputBValue = GetInputValue<RenderTexture>("b");
        return base.AllTexturesAreNotNull() && inputAValue && inputBValue;
    }

    protected override void SetShaderVariables()
    {
        base.SetShaderVariables();
        if (AllTexturesAreNotNull())
        {
            ComputeShaderInstance.SetTexture(KernelIndex, "InputA", GetInputValue<RenderTexture>("a"));
            ComputeShaderInstance.SetTexture(KernelIndex, "InputB", GetInputValue<RenderTexture>("b"));
        }
    }
}