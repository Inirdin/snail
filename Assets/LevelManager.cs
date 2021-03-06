﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public static LevelManager instance;
    public GameObject[] levels;
    public GameObject player;
    public int currentLevel = 0;



    private void Awake()
    {
        if(LevelManager.instance != null)
        {
            Destroy(gameObject);
        }

        else LevelManager.instance = this;
    }
    public void NextLevel()
    {
        levels[currentLevel].SetActive(false);
        currentLevel += 1;
        levels[currentLevel].SetActive(true);
        player.transform.position = levels[currentLevel].transform.GetChild(0).transform.position;
    }

    public void Respawn()
    {
        player.transform.position = levels[currentLevel].transform.GetChild(0).transform.position;
    }
}
