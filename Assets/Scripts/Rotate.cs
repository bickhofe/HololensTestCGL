using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public Vector3 axis;
    public float speed;
    public bool active = false;

	public void toggle () {
        if (!active) active = true;
        else active = false;
	}
	
	void Update () {
        if (active) transform.Rotate(axis * speed * Time.deltaTime);
	}
}
