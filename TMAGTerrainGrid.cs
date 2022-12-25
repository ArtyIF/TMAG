using UnityEngine;
using TriInspector;

[ExecuteAlways]
[DeclareBoxGroup("graph", Title = "Graph")]
[DeclareFoldoutGroup("grid", Title = "Grid")]
[DeclareFoldoutGroup("terrain", Title = "Terrain")]
public class TMAGTerrainGrid : MonoBehaviour
{
    // TODO: move to a separate class or struct
    private readonly int[] terrainResolutionValues = { 33, 65, 129, 257, 513, 1025, 2049, 4097 };

    #region Graph Settings
    [GroupNext("graph")]

    [Required]
    [LabelText("Graph")]
    public TMAGGraph graph;
    #endregion

    #region Grid Settings
    [GroupNext("grid")]

    //[ValidateInput(nameof(CheckGridSizePositivity))]
    //[LabelText("Grid Size")]
    //public Vector2Int gridSize = new(1, 1);

    [ValidateInput(nameof(CheckTileSizePositivity))]
    [LabelText("Tile Size")]
    public Vector3 tileSize = new(1000.0f, 600.0f, 1000.0f);
    #endregion

    #region Terrain Settings
    [GroupNext("terrain")]

    [Dropdown(nameof(terrainResolutionValues))]
    [LabelText("Resolution")]
    public int terrainResolution = 513;
    #endregion

    private RenderTexture heightmapRTToApply = null;

    #region Buttons
    [Button]
    [Group("graph")]
    private void GenerateTerrainGrid()
    {
        graph.terrainResolution = terrainResolution;
        graph.tileSize = tileSize;
        heightmapRTToApply = (RenderTexture)graph.GetHeightmapNode().GetValue(null);

        if (heightmapRTToApply)
        {
            TerrainData terrainData = new()
            {
                heightmapResolution = terrainResolution,
                size = tileSize
            };

            RenderTexture previousRT = RenderTexture.active;
            RenderTexture.active = heightmapRTToApply;

            Texture2D heightmapTex = new(terrainResolution, terrainResolution, UnityEngine.Experimental.Rendering.GraphicsFormat.R32_SFloat, UnityEngine.Experimental.Rendering.TextureCreationFlags.DontUploadUponCreate);
            heightmapTex.ReadPixels(new(0, 0, terrainResolution, terrainResolution), 0, 0, false);
            heightmapTex.Apply(false, false);

            RenderTexture.active = previousRT;

            float[,] heights = new float[terrainResolution, terrainResolution];
            for (int y = 0; y < terrainResolution; y++)
            {
                for (int x = 0; x < terrainResolution; x++)
                {
                    heights[y, x] = heightmapTex.GetPixel(x, y).r;
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
    #endregion

    #region Validators
    /* private TriValidationResult CheckGridSizePositivity()
    {
        if (gridSize.x < 1 || gridSize.y < 1) return TriValidationResult.Error("Grid size cannot be negative or zero");
        return TriValidationResult.Valid;
    } */

    private TriValidationResult CheckTileSizePositivity()
    {
        if (tileSize.x <= 0 || tileSize.y <= 0 || tileSize.z <= 0) return TriValidationResult.Error("Tile size cannot be negative or zero");
        return TriValidationResult.Valid;
    }
    #endregion
}
