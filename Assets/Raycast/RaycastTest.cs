using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour {

	// Use this for initialization
	LayerMask layerMask;
	public GameObject player;
	void Start () {
		layerMask = 1<< LayerMask.NameToLayer("Ground");
		layerMask= ~layerMask;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit[] hits= Physics.RaycastAll(player.transform.position,Vector3.right,10f,layerMask);
		
		foreach(var hit in hits)
		{
			Debug.Log(hit.collider.gameObject.name);
		}


	}
}
