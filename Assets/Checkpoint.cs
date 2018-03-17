using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {
    public GameObject respawnPoint;
    public Vector2 point;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        point = respawnPoint.transform.position;
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerControl>().RespawnOutside(true, point);
        }
    }
}
