using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void Update (){
	}
	
	// Update is called once per frame
	void OnBecameInvisible() {
		Destroy (gameObject);

	}
}
