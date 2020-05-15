using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
	//public UiManager ui;
	public GameObject gem;

	

	void Start()
	{
		//ui = GameObject.FindWithTag("ui").GetComponent<UiManager>();
	}

	private void OnTriggerEnter2D(Collider2D col)
	
	//void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Ball")

			
		Destroy(gem) ;
		Debug.Log("Broke");
	}
}
