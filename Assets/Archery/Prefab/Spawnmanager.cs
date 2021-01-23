using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    public float spawnystart = 0f;
    public float SpawnyEnd = 0f;
    public float Spawn_x = 0f;
    public float SpawnTimer = 0.5f;

    [SerializeField]
    private GameObject StandardEnemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Vector2 posToSpawn = new Vector2(Spawn_x, Random.Range(spawnystart, SpawnyEnd));
            GameObject Enemy = Instantiate(StandardEnemyPrefab, posToSpawn, Quaternion.identity);
            Enemy.transform.rotation = StandardEnemyPrefab.transform.rotation;
            Enemy.SetActive(true);
            yield return new WaitForSeconds(SpawnTimer);

        }


    }
}