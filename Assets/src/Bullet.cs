using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	public const float lifetime = 10f;
	private float _lifetime = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_lifetime += Time.deltaTime;
		if(_lifetime >= lifetime)
			Destroy(gameObject);	
	}
}
