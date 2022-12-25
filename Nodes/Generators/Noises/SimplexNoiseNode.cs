[CreateNodeMenu("TMAG/Generators/Noise/Simplex")]
public class SimplexNoiseNode : TMAGComputeShaderNodeBase
{
    public float scale = 10.0f;
    protected override string KernelName { get; } = "SimplexNoiseNodeMain";
    protected override string NodeName { get; } = "Simplex Noise";

    protected override void SetShaderVariables()
    {
        base.SetShaderVariables();
        ComputeShader.SetFloat("Scale", scale);
    }
}