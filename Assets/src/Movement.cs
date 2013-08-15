using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public Transform head;
	public Transform cam;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		// look left/right
		double x = Input.GetAxisRaw("mousex");
		double y = Input.GetAxisRaw("mousey");
		
		transform.Rotate(Vector3.up, (float)(x * Time.deltaTime * 100f));
		
	}
	
	void FixedUpdate () {
		
		const double accel = 5000f;
		double f = Input.GetAxisRaw("vert");
		if(f != 0)
			rigidbody.AddRelativeForce(0f, 0f, (float)(f * Time.deltaTime * accel), ForceMode.Acceleration);
		
		double l = Input.GetAxisRaw("hor");
		if(l != 0)
			rigidbody.AddRelativeForce((float)(l * Time.deltaTime * accel * 0.8), 0f, 0f, ForceMode.Acceleration);
		
		
		// speed limit
		float mag = rigidbody.velocity.magnitude;
		const float speedlimit = 50f;
		if(mag > speedlimit) {
//			rigidbody.velocity = Vector3.Normalize(rigidbody.velocity) * 10f;
			float diff = (mag - speedlimit);
			rigidbody.AddForce(-diff / mag * rigidbody.velocity, ForceMode.VelocityChange);
			
			Vector3 newv = rigidbody.velocity + (-diff / mag * rigidbody.velocity);
			Debug.Log("new vel:" + newv.magnitude);
			
			Debug.Log("OVER THE SPEED LIMIT: "+ mag + ". New Mag: " + rigidbody.velocity.magnitude);
//			rigibody.addForce( rigidbody.velocity.Normalize() * -diff);
		}
	}
}
