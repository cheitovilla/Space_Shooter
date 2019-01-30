using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Destroy(gameObject,3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
