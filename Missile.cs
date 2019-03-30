using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour {


	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag != "Player") {Destroy(gameObject);}
	}

	void Start () 
	{
	
	}

	void Update () 
	{
	
	}
}
