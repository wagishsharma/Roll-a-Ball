using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {



	// Update is called once per frame or when no force 
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45)* Time.deltaTime) ;// for smooth handling
	}
}
