using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSprite : MonoBehaviour
{
    public GameObject[] spritePrefab;
    private int spriteCount = 0;
    public void InitSprite()
    {
        spriteCount++;
        if (spriteCount % 2 == 0)
        {
            Instantiate(spritePrefab[0], new Vector3(-4, 2, 0) + Vector3.down * (spriteCount), Quaternion.identity);
        }
        else
        {
            Instantiate(spritePrefab[1], new Vector3(4, 2, 0) + Vector3.down * (spriteCount), Quaternion.identity);
        }

        Debug.Log("Spawned object");
    }
}
