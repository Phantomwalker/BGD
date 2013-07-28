using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(1, 2, 8);	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0.0f, 1.1f, 0.0f);
		transform.localScale = new Vector3(Time.time, Time.time, Time.time);
	}
}
