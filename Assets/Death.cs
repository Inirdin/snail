using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.GetComponent<PlayerControl>().location == false)
            {
                collision.GetComponent<PlayerControl>().RespawnOutside(false, new Vector2(0f, 0f));
            }
            else
            {
                LevelManager.instance.GetComponent<LevelManager>().Respawn();
            }
        }
    }
}
