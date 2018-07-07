using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Tile_Wall : Tile
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

#if UNITY_EDITOR
    // The following is a helper that adds a menu item to create a RoadTile Asset
    [MenuItem("Assets/Create/WallTile")]
    public static void CreateRoadTile()
    {
        string path = EditorUtility.SaveFilePanelInProject("Save Wall Tile", "New Wall Tile", "Asset", "Save Wall Tile", "Assets");
        if (path == "")
            return;
        AssetDatabase.CreateAsset(ScriptableObject.CreateInstance<Tile_Wall>(), path);
    }
#endif

}


