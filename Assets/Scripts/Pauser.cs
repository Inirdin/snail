using UnityEngine;
using System.Collections;

public class Pauser : MonoBehaviour {
	private bool paused = false;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Escape))
		{
			paused = !paused;
		}

        if (paused)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            Time.timeScale = 0;
        }
		else
        {
            transform.GetChild(0).gameObject.SetActive(false);
            Time.timeScale = 1;
        }
	}
}
