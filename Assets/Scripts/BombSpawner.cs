using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BombSpawner : MonoBehaviour
{
    public Tilemap tilemap;
    public GameObject bombPrefab;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var cell = tilemap.WorldToCell(worldPoint);
            var cellCenterPoint = tilemap.GetCellCenterWorld(cell);

            Instantiate(bombPrefab, cellCenterPoint, quaternion.identity);
        }    
    }
}
