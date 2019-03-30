using UnityEngine;
using System.Collections;

public class SideWall : MonoBehaviour {

	public static bool Collide = false;

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag == "Enemy") 
		{
			Collide = true;
		}
	}

	void OnTriggerEnter2D (Collider2D trigger)
	{
		if (trigger.gameObject.tag == "Enemy") 
		{
			Collide = true;
		}
	}

	void Start () 
	{	
	}

	void Update () 
	{
	}
}
