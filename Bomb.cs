using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {
	
	//private Enemy enemy;

	void OnCollisionEnter2D (Collision2D collision)
	{
		/*if (collision.gameObject.tag == "Enemy") 
		{
			//Physics2D.IgnoreCollision(enemy.GetComponent<Collider2D>(),GetComponent<Collider2D>());
			Collider2D x = collision.transform.collider2D;
			print(x);
			print(this.collider2D);
			//Physics2D.IgnoreCollision(collision.gameObject.collider2D,this.collider2D,true);
			Physics2D.IgnoreCollision(x,this.transform.collider2D,true);
			//Physics2D.IgnoreCollision(this.collider2D,x,true);
			print(Physics2D.GetIgnoreCollision(x, this.collider2D));
		}*/
		if (collision.gameObject.tag != "Enemy") 
		{
			Destroy(gameObject);
		}
		print(collision.gameObject.tag);
	}

	void Start () 
	{
		//enemy = GameObject.FindObjectOfType<Enemy>();
		//Physics2D.IgnoreCollision(enemy.collider2D,this.collider2D);
		//Physics2D.IgnoreCollision(Enemy.GetComponent<Collider2D>(),this.collider2D);
	}

	void Update () 
	{
	}
}
