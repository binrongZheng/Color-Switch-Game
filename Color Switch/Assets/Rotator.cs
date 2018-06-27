using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public float speed = 100f;
	private int direection=1;

	void Start(){
		direection=Random.Range(0,1);
		if(direection==0)
			speed=Random.Range(100,150);
		else
			speed=Random.Range(-100,-150);
	}
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f,0f,speed*Time.deltaTime);
	}
}
