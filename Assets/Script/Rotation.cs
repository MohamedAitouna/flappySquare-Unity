using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Rotation : MonoBehaviour {
	private int cof;
	private int sc=0;
	private AudioSource source;
	private int beginEnd=0;
	public Text maxScoreT;
	public GameObject replay;
	//private int lose = 0;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		maxScoreT.text = "";
		cof = 1;
	}
	void lose(){
		sc = PlayerPrefs.GetInt("Score");
		if (GamePlay.scoreI >= sc) {
			PlayerPrefs.SetInt ("Score", GamePlay.scoreI);
			maxScoreT.text = "Max :" + GamePlay.scoreI;
		} else
			maxScoreT.text = "Max :" + sc;
	}
	void OnCollisionEnter2D(Collision2D info){
		lose ();
		print ("hello");
	    Instantiate (replay);
		Time.timeScale = 0.0f;
		Destroy (this.gameObject);
	}
	// Update is called once per frame
	void Update () {
		cof ++;
		if (transform.position.y < -0.35f || transform.position.y>2.34f) {
			lose ();
			Instantiate (replay);
			Time.timeScale = 0.0f;
			Destroy (this.gameObject);
		}
		//transform.Rotate(Vector3.forward * Time.deltaTime*90);
		transform.position-=new Vector3 (0,0.1f*cof,0)*Time.deltaTime;
		if (Input.GetKeyDown ("space")) {
			source.Play();
			transform.position+=new Vector3 (0,0.2f,0);
			cof = 1;
			print ("space key was pressed");
		}
		for (int i = 0; i < Input.touchCount; i++) {
			Touch touch = Input.GetTouch (i);
			if (touch.phase == TouchPhase.Began) {
				source.Play ();
				transform.position += new Vector3 (0, 0.2f, 0);
				cof = 1;
			}
		}
	}
}
