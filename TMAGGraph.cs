using System;
using UnityEngine;
using XNode;

[CreateAssetMenu]
public class TMAGGraph : NodeGraph
{
    #region Current State Parameters
    [HideInInspector]
    public Vector2Int currentGridPosition;
    #endregion

    // TODO: move into a separate struct, as well as TMAGTerrainGrid's settings maybe
    #region Grid Settings
    [HideInInspector]
    public Vector2Int gridSize;
    [HideInInspector]
    public Vector3 tileSize;
    #endregion

    #region Terrain Settings
    [HideInInspector]
    public int terrainResolution = 513;
    #endregion

    public HeightmapNode GetHeightmapNode() {
        foreach (Node node in nodes)
        {
            if (node is HeightmapNode heightmapNode)
            {
                return heightmapNode;
            }
        }
        throw new NullReferenceException("No Heightmap node found in graph");
    }

    /* public TexturesNode GetTexturesNode() {
        foreach (Node node in nodes)
        {
            if (node is TexturesNode texturesNode)
            {
                return texturesNode;
            }
        }
        throw new NullReferenceException("No Textures node found in graph");
    } */
}