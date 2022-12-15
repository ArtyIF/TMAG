using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TriInspector;
using XNode;

[ExecuteAlways]
[DeclareFoldoutGroup("generator", Title = "Generator", Expanded = true)]
[DeclareFoldoutGroup("grid", Title = "Grid (not supported yet)")]
[DeclareFoldoutGroup("terrain", Title = "Terrain")]
public class TMAGTerrainGrid : MonoBehaviour
{
    // TODO: move to a separate class or struct
    private readonly int[] terrainResolutionValues = { 33, 65, 129, 257, 513, 1025, 2049, 4097 };

    #region Generator Settings
    [GroupNext("generator")]

    [Required]
    [LabelText("Graph")]
    public TMAGGraph graph;
    #endregion

    #region Grid Settings
    [GroupNext("grid")]

    [ValidateInput(nameof(CheckGridSizePositivity))]
    [LabelText("Grid Size")]
    public Vector2Int gridSize = new(1, 1);

    [ValidateInput(nameof(CheckTileSizePositivity))]
    [LabelText("Tile Size")]
    public float tileSize = 100.0f;
    #endregion

    #region Terrain Settings
    [GroupNext("terrain")]

    [Dropdown(nameof(terrainResolutionValues))]
    [LabelText("Resolution")]
    public int terrainResolution = 513;
    #endregion

    private CustomRenderTexture heightmapRTToApply = null;

    #region Buttons
    [Button]
    [Group("generator")]
    private void GenerateTerrainGrid()
    {
        graph.terrainResolution = terrainResolution;
        heightmapRTToApply = (CustomRenderTexture)graph.GetHeightmapNode().GetValue(graph.GetHeightmapNode().GetOutputPort("output"));
    }
    #endregion

    protected void Update() {
        if (heightmapRTToApply) {
            TerrainData terrainData = new()
            {
                heightmapResolution = terrainResolution,
                size = new(1000, 600, 1000)
            };

            RenderTexture previousRT = RenderTexture.active;
            RenderTexture.active = heightmapRTToApply;

            // The commented-out way is faster, but it treats the texture as a signed one, so any heights above a certain point turn into very deep holes
            // terrainData.CopyActiveRenderTextureToHeightmap(new(0, 0, terrainResolution, terrainResolution), new(), TerrainHeightmapSyncControl.HeightAndLod);
            // terrainData.DirtyHeightmapRegion(new(0, 0, terrainResolution, terrainResolution), TerrainHeightmapSyncControl.HeightAndLod);
            // terrainData.SyncHeightmap();

            // The way below is more classic and brute-force-y, but it actually works
            Texture2D heightmapTex = new(terrainResolution, terrainResolution, UnityEngine.Experimental.Rendering.GraphicsFormat.R16_UNorm, UnityEngine.Experimental.Rendering.TextureCreationFlags.DontUploadUponCreate);
            heightmapTex.ReadPixels(new(0, 0, terrainResolution, terrainResolution), 0, 0, false);
            heightmapTex.Apply(false, false);

            RenderTexture.active = previousRT;

            float[,] heights = new float[terrainResolution, terrainResolution];
            for (int y = 0; y < terrainResolution; y++)
            {
                for (int x = 0; x < terrainResolution; x++)
                {
                    heights[x, y] = heightmapTex.GetPixel(x, y).r;
                }
            }
            terrainData.SetHeights(0, 0, heights);

            Debug.Log("Textures not implemented yet");

            for (int i = 0; i < transform.childCount; i++)
            {
                DestroyImmediate(transform.GetChild(i).gameObject);
            }
            GameObject terrainGO = Terrain.CreateTerrainGameObject(terrainData);
            terrainGO.name = "Generated Terrain Object";
            terrainGO.transform.parent = transform;

            heightmapRTToApply = null;
        }
    }

    #region Validators
    private TriValidationResult CheckGridSizePositivity()
    {
        if (gridSize.x < 1 || gridSize.y < 1) return TriValidationResult.Error("Grid size cannot be negative or zero");
        return TriValidationResult.Valid;
    }

    private TriValidationResult CheckTileSizePositivity()
    {
        if (tileSize <= 0) return TriValidationResult.Error("Tile size cannot be negative or zero");
        return TriValidationResult.Valid;
    }
    #endregion
}
