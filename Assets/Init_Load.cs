using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Init_Load : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GameLoad());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator GameLoad()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
}
