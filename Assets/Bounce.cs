using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


	float time = 0f;
	void Update () {
		time += Time.deltaTime;
		float y = Mathf.Cos (time);
		this.transform.position = new Vector3 (0, y, 4);
	}
}
