[CreateNodeMenu("TMAG/Generators/Noise/Perlin")]
public class PerlinNoiseNode : TMAGComputeShaderNodeBase
{
    public float scale = 10.0f;
    protected override string KernelName { get; } = "PerlinNoiseNodeMain";
    protected override string NodeName { get; } = "Perlin Noise";

    protected override void SetShaderVariables()
    {
        base.SetShaderVariables();
        ComputeShaderInstance.SetFloat("Scale", scale);
    }
}