using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	public GameObject Missile;

	private float Cooldown;
	private LevelManager levelmanager;

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag == "Bomb") 
		{
			levelmanager.LoadLevel("Lose");
		}
	}

	void Start () 
	{
		this.transform.position = new Vector3 (8f,1f,0f);
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
	}

	void Update ()
	{
		if (Input.GetKey("left")) {MoveLeft();}
		if (Input.GetKey("right")) {MoveRight();}
		transform.position = new Vector3(Mathf.Clamp(this.transform.position.x,0.35f,15.65f),1f,0f);
		if (Input.GetKeyDown("space") && Cooldown <= Time.time) {Shoot();}
	}
	
	void MoveLeft()
	{
		transform.Translate(-0.07f,0f,0f);
	}

	void MoveRight()
	{
		transform.Translate(0.07f,0f,0f);
	}

	void Shoot()
	{
		GameObject MissileShot = Instantiate(Missile, new Vector3(this.transform.position.x, 1.5f, 0f), Quaternion.identity) as GameObject;
		MissileShot.rigidbody2D.velocity = new Vector2(0f,5f);
		Cooldown = Time.time + 0.5f;
	}
}
