Shader "Hidden/TMAG/PerlinNoiseNode"
{
    Properties {
        _Scale("Scale", Float) = 1.0
    }

     SubShader
     {
        Blend One Zero

        Pass
        {
            Name "PerlinNoiseNode"

            CGPROGRAM
            #include "UnityCustomRenderTexture.cginc"
            #include "Packages/jp.keijiro.noiseshader/Shader/ClassicNoise2D.hlsl"
            #pragma vertex CustomRenderTextureVertexShader
            #pragma fragment frag
            #pragma target 3.0

            float _Scale;

            float4 frag(v2f_customrendertexture IN) : SV_Target
            {
                float2 uv = IN.localTexcoord.xy * _Scale;
                return (ClassicNoise(uv) + 1.0) * 0.5;
            }
            ENDCG
        }
    }
}
