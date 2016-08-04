using UnityEngine;
using System.Collections;

public class detectCollison : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter2D(Collision2D info){
		print ("hello");
		//Destroy (this.gameObject);
	}
}
