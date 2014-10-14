using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	public float time;
	private float current_time;
	// Use this for initialization
	void Start () {
		current_time = 0;
	}

	// Update is called once per frame
	void Update () { 
		Vector3 campos = Camera.main.transform.position;
		if (transform.position.y > campos.y) {
				current_time += Time.deltaTime;
				if (current_time > time)
						Application.LoadLevel ("Menu");
		} else
				current_time = 0;
}
}
