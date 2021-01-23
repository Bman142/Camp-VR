using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public int score = 1;
    public float speed = 4f;
    public float ystart = 10;
    public float loop = 16f;
    public float yend = -10;
    public float xSpawn = -27f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        if (transform.position.x > loop)
        {
           // transform.position = new Vector2(xSpawn,(ystart, yend));
        }
    }


}