using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour {

    public GameObject levels;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        levels.GetComponent<LevelManager>().NextLevel();
    }
}
