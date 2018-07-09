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

    public int m_MaxLength_Upper;
    public int m_MaxLength_Lower;

    public int m_MaxHeight_Upper;
    public int m_MaxHeight_Lower;

    // Use this for initialization
    void Start()
    {
        //Create randomly sized Maximum size dependant on set bounderies
        CreateSpace(Random.Range(m_MaxLength_Lower, m_MaxLength_Upper),
                    Random.Range(m_MaxHeight_Lower, m_MaxHeight_Upper)
                    );
    }

    // Update is called once per frame
    void Update ()
    {

    }

    //Create initial Square which rooms will occupy
    void CreateSpace(int _MaxLength, int _MaxHeight)
    {
        m_TerrainMap.SetTile(new Vector3Int(0, 0, 0), _tile);
        for (int i = 0; i < _MaxLength; i++)
        {
            for (int j = 0; j < _MaxHeight; j++)
            {
                m_TerrainMap.SetTile(new Vector3Int(i, j, 0), _tile);
            }
        }
    }


}
