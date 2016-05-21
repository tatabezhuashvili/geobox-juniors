using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game_Controller : MonoBehaviour {
	public float Timer;
	public GameObject UniversalBall;
	public List <Sprite> spriteList; 
	float oldTimer;

	void Start () 
	{

		oldTimer = Timer;
	}

	// Update is called once per frame
	void Update () {
		print (Time.deltaTime);
		Timer -= Time.deltaTime;
		if (Timer <= 0)
		{
	        Instantiate (UniversalBall,new Vector3 (Random.Range(-2.6f, 2.6f),8,0), Quaternion.identity);
			UniversalBall.GetComponent<SpriteRenderer>().sprite = spriteList[Random.Range(0,spriteList.Count)];
			if(oldTimer >0.1f) {oldTimer -= 0.1f;
			}
			Timer = oldTimer;
		
		}

}
}
