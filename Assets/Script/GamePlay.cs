using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GamePlay : MonoBehaviour {
	public GameObject barTop, barBottom;
	public float ecart = 2.25f;
	public float coolDown =3f;
	public Text scoreT;
	public static int	scoreI=0;
	private float positionGeneration;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1.0f;
		scoreI=0;
	}
	
	// Update is called once per frame
	void Update () {
		 scoreT.text = " " + scoreI;
		if (coolDown > 0) {
			coolDown -= Time.deltaTime;
		} else {
			coolDown = 1.75f;
			positionGeneration = Random.Range (1.5f, 2.75f);
			Instantiate (barTop,new Vector3(2.5f,positionGeneration,-9f),Quaternion.identity);
			Instantiate (barBottom,new Vector3(2.5f,positionGeneration-ecart,-9f),Quaternion.identity);
		}
	}
}
