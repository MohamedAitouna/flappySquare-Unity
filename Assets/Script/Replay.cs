using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Replay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space"))
			SceneManager.LoadScene (0, LoadSceneMode.Single);
		for (int i = 0; i < Input.touchCount; i++) {
			Touch touch = Input.GetTouch (i);
			if (touch.phase == TouchPhase.Began) {
					SceneManager.LoadScene (0, LoadSceneMode.Single);
			}
		}
	}
}
