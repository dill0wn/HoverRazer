using UnityEngine;
using System.Collections;

public class PopPopMothafuckah : MonoBehaviour {
	
	public GameObject bullet;

	// Use this for initialization
	void Start () {
	
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")) {
			fireMissile();
		}
	}
	
	void fireMissile () {
		Vector3 spawnPos = transform.TransformPoint(new Vector3(0f, 1.5f, 1f));
//		Quaternion rot = Quaternion.;
		GameObject b = GameObject.Instantiate(bullet, spawnPos, transform.rotation) as GameObject;
		
		//b.transform.LookAt(
		
		b.rigidbody.AddRelativeForce(0f, 0f, 100f, ForceMode.Impulse);
		b.rigidbody.AddForce(rigidbody.velocity);
	}
}
