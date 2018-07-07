using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.Tilemaps;

public class DungeonManager : MonoBehaviour {

    public Tilemap m_TerrainMap;
    public Tilemap m_CharacterMap;
    public Tilemap m_ObjectMap;

    public Tile _tile;

    int i = 0;

    // Use this for initialization
    void Start()
    {
        m_TerrainMap.SetTile(new Vector3Int(0, 0, 0), _tile);

    }

    // Update is called once per frame
    void Update () {
        m_TerrainMap.SetTile(new Vector3Int(i, 1, 1), _tile);
        i++;
        Debug.Log(i);
    }
}
