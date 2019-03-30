using UnityEngine;
using System.Collections;

public class BottomFloor : MonoBehaviour {

	public Bomb bomb;

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag == "Bomb") 
		{
			Destroy(bomb);
		}
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
