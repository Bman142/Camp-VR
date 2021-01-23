using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hub_BadgeUpdate : MonoBehaviour
{
    [SerializeField] Manager.GameManager.Games game;
    private Manager.GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = Manager.GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Image>().enabled = manager.GetBadgeState(game);
    }
}