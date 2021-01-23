using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction_SpawnMoreWood : MonoBehaviour
{
    public int spawnedWoodAmount;
    public int minWood;
    public GameObject woodChop;
    public int woodCount;

    private void Update()
    {
        
        woodCount = GameObject.FindGameObjectsWithTag("WoodChoppable").Length + GameObject.FindGameObjectsWithTag("Woodchops").Length;

        if (woodCount < minWood)
        {
            for (int i = 0; i < spawnedWoodAmount; i++)
            {
                var woodChopObj = Instantiate(woodChop, new Vector3(this.transform.position.x + Random.Range(-1f, 1f), this.transform.position.y + Random.Range(-0.1f, 0.1f), this.transform.position.z + Random.Range(-1f, 1f)), Quaternion.identity);
                woodChopObj.transform.rotation = Random.rotation;
            }
        }

    }

}
