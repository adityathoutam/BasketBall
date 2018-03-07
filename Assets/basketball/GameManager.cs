using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	
	public GameObject ball;
Vector3 throwforce;
	public Slider slider;
	GameObject ballClone;


	
	bool hit;
	// Use this for initialization
	void Start () {
		throwforce= new Vector3(0,7,25);
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	 {
		 Vector3 a = new  Vector3(-5,0,0);
		Vector3 b = new Vector3(5,0,0);
		 float pingPong = Mathf.PingPong(Time.time * 0.5f, 1);
		Vector3 speed = Vector3.Lerp(a,b,pingPong);
		slider.value=speed.x;
		
		
		

		if(Input.GetKey(KeyCode.W))
        {
            //basket is 0,7,25
			throwforce.y = throwforce.y+slider.value;
			throwforce.z = throwforce.z+slider.value;
			//if(ballClone==null)
            //ballClone = Instantiate(ball,new Vector3(0,-8,-50),Quaternion.identity) as GameObject;
			
			ball.GetComponent<Rigidbody>().velocity= throwforce;
			ball.GetComponent<Rigidbody>().useGravity =true;
			hit=true;
        }
		
		
		
	 }

}
