using UnityEngine;
using System.Collections;

public class TreeGen : MonoBehaviour {
	
	public GameObject[] treeTypes;
	public Terrain terrain;

	// Use this for initialization
	void Start () {
		GameObject t;
		Vector3 pos;
		GameObject tree;
		for(int i = 0; i < 10; i++)
		{
			t = treeTypes[(int)(Random.value * 0.99 * treeTypes.Length)];
			pos = new Vector3(Random.value * terrain.collider.bounds.extents.x, 0, 0);
			tree = GameObject.Instantiate(t, pos, Quaternion.identity) as GameObject;
			
			tree.transform.localScale *= 10f;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
