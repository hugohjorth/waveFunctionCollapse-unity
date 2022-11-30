using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkManeger : MonoBehaviour
{
    public Dictionary<Vector2, Chunk> chunks;
    public GameObject player;
    public int worldSize = 1000;
    public int chunkSize = 32;



    public void createChunk()
    {
        int numOfChunks = worldSize / chunkSize;
        for (int i = 0; i < numOfChunks; i++)
        {
            GameObject newChunk = new GameObject(name = i.toString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = player.transform.position;
    }
}
