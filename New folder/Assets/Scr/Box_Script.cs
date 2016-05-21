using UnityEngine;
using System.Collections;

public class Box_Script : MonoBehaviour {

	void Start ()
    {
        
            
	}
	
	void Update ()
    {
        if(Input.GetKey(KeyCode.LeftArrow) && gameObject.transform.position.x >= -2.3f)
        {
            gameObject.transform.Translate(-0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow) && gameObject.transform.position.x <=2.3f)
        {
            gameObject.transform.Translate(0.1f, 0, 0);
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        Destroy(other.gameObject);
		GlobalParams.Score++;
		print (GlobalParams.Score);


    } 
}
