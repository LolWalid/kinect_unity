using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public GameObject handR;
	public GameObject handL;
	private Vector3 vitesse;	

	// Use this for initialization
	void Start () {
		vitesse = new Vector3 (0, 0, - Random.Range (0.1f, 2f));
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (vitesse);
		if (handR.transform.position.x > 4 && transform.position.x > 4)
				Debug.Log ("Right");
		else if ((handL.transform.position.x < -4 || handR.transform.position.x < -4) && transform.position.x < -4)
				Debug.Log ("Left");
		else if (handR.transform.position.x > 4 && transform.position.x > 4)
				Debug.Log ("top");


	}
}
