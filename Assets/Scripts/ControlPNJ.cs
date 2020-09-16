using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPNJ : MonoBehaviour
{
	float speed;
  
    public float mana = 0f;
  	
    // Start is called before the first frame update
    void Start()
    { 
        speed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(new Vector3(speed, 0,0));
        }
        
		if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(new Vector3(-speed, 0, 0));
        }
		
        if (Input.GetKey(KeyCode.UpArrow)) { 
            transform.Translate(new Vector3(0, 0, speed));
        }
		
        if (Input.GetKey(KeyCode.DownArrow)){

            transform.Translate(new Vector3(0, 0,-speed));

        }

    }
	
	void OnCollisionEnter(Collision col) {
 
        if (col.gameObject.tag=="col") {
            Debug.Log("el pnj ha colisionado con el cubo");
        }

    }

    void OnTriggerEnter(Collider obj) {
     
        if (obj.tag=="col") {
            mana += 0.5f;
        }

    }
	
}
