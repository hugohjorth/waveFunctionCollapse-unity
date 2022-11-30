using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Algorithm : MonoBehaviour
{

    public Tile newTile;
    public Tilemap theMapping;

    private void LateUpdate()
    {
        Vector3Int currentCell = theMapping.WorldToCell(transform.position);


        if (!theMapping.HasTile(currentCell))
        {
            theMapping.SetTile(currentCell, newTile);
        }

    }


}
