#if UNITY_EDITOR
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class ConvertRAWToTextureWindow : EditorWindow
{
    public int resolution = 513;
    public bool eightBit = false;
    public string savePath = "Assets/TerrainTexture.asset";

    [MenuItem("Tools/TMAG/Convert RAW To Texture")]
    protected static void Init()
    {
        ConvertRAWToTextureWindow window = GetWindow(typeof(ConvertRAWToTextureWindow)) as ConvertRAWToTextureWindow;
        window.Show();
    }

    void Convert()
    {
        string path = EditorUtility.OpenFilePanel("Select RAW file", Application.dataPath + "/..", "raw");
        if (path.Length > 0)
        {
            byte[] bytes = File.ReadAllBytes(path);
            Texture2D resultingTexture = new(resolution, resolution, eightBit ? GraphicsFormat.R8_UNorm : GraphicsFormat.R16_UNorm, TextureCreationFlags.None);
            resultingTexture.LoadRawTextureData(bytes);
            AssetDatabase.CreateAsset(resultingTexture, savePath);
        }
    }

    protected void OnGUI()
    {
        EditorGUILayout.IntField("Resolution", resolution);
        EditorGUILayout.Toggle("Data is 8-bit", eightBit);
        EditorGUILayout.TextField("Save Path", savePath);
        GUILayout.Label("For now, only Windows format is supported");
        if (GUILayout.Button("Select RAW file"))
        {
            Convert();
        }
    }
}
#endif