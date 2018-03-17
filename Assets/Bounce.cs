using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {
    public float bounceSensitivity = 70f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("JUMP");
        if (collision.tag == "Player")
        {
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0f,0f);
            collision.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, bounceSensitivity), ForceMode2D.Impulse);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
