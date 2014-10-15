using UnityEngine;
using System.Collections;

public class Bullets : MonoBehaviour {
	
	public GameObject bullet; 
	private float coolDown;
	
	// Use this for initialization
	void Start () {
		coolDown = 0;	
	}
	
	// Update is called once per frame
	void Update () {
		if (coolDown < 0){
			float x = - Random.Range (5f, 15f);
			float y = Random.Range (5f, 10f);
			Vector3 position = new Vector3(x, y, 100f);
			GameObject.Instantiate(bullet, position, Quaternion.identity);
			coolDown = 2;
		}
		coolDown -= Time.deltaTime;
	}
	
}
