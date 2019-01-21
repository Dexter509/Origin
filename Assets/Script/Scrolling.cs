using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {



	public float scrollingSpeed;
	public float tilesize;
	public Transform currentObject;

	void Start () {
		currentObject = GetComponent<Transform>();
	}


	void Update () {
		currentObject.position = new Vector3 (Mathf.Repeat (Time.time * scrollingSpeed, tilesize), currentObject.position.y, currentObject.position.z );
	}
}
