using UnityEngine;
using System.Collections;

public class MoveBar : MonoBehaviour {
	public int score = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 (0.75f,0,0)*Time.deltaTime;
		if (transform.position.x < -1.45 && score == 0) {
			score = 1;
			GamePlay.scoreI+=1;
		}
		if (transform.position.x < -2.5f) {
			Destroy (this.gameObject);
		}
	}
}
