using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour {

	public GameObject player;
	public LayerMask layerMask;
	void Start () {
		//layerMask = LayerMask.NameToLayer("")
	}
	
	// Update is called once per frame
	void Update () {
			Movement();
			LeftHit();
			RightHit();
			Downhit();
		
	}
	void LeftHit()
	{
		RaycastHit[] hits= Physics.RaycastAll(player.transform.position,Vector3.left,1f);
		foreach(var hit in hits)
		{
			Debug.Log(hit.collider.gameObject.name);
		}
	}
	void RightHit()
	{
		RaycastHit[] hits= Physics.RaycastAll(player.transform.position,Vector3.right,1f);
		foreach(var hit in hits)
		{
			Debug.Log(hit.collider.gameObject.name);
		}

	}
	void Downhit()
	{
		RaycastHit[] hits= Physics.RaycastAll(player.transform.position,Vector3.down,1f);
		foreach(var hit in hits)
		{
			Debug.Log(hit.collider.gameObject.name);
		}

	}
	void Movement()
	{
		Vector3 playerInput;
		playerInput.x = Input.GetAxis("Horizontal");
		playerInput.y = Input.GetAxis("Vertical");

		Debug.Log(playerInput.x);
		Debug.Log(playerInput.y);
		player.GetComponent<Rigidbody>().AddForce (new Vector3(playerInput.x+300,playerInput.y+300,0));
	}

}
