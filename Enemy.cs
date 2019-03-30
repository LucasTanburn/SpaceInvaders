using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {


	public static int EnemyCount = 0;
	public GameObject Bomb;

	private float velocity = 0.5f;
	private LevelManager levelmanager;


	void OnCollisionEnter2D (Collision2D collision)
	{
		if ( collision.gameObject.tag == "Missile") 
		{
			Destroy(gameObject);
			EnemyCount--;
			EnemyCheck();
		}
	}

	IEnumerator Movement()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1.0f);
			this.transform.Translate(new Vector2(velocity,0f));
			if (SideWall.Collide)
			{
				yield return new WaitForSeconds(1.0f);
				this.transform.Translate(new Vector2(0f,-0.5f));
				velocity = -velocity;
			}
			SideWall.Collide = false;
		}
	}


	void Start () 
	{
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
		EnemyCount++;
		StartCoroutine("Movement");
	
	}

	void Update () 
	{
		BombCheck();
	}

	void BombCheck()
	{
		int check = Random.Range(0,1000);
		if (check == 862)
		{
			GameObject BombShot = Instantiate(Bomb, new Vector3(this.transform.position.x, this.transform.position.y-1, this.transform.position.z), Quaternion.identity) as GameObject;
			BombShot.rigidbody2D.velocity = new Vector2(0f,-3f);
		}
	}

	void EnemyCheck()
	{
		if (Enemy.EnemyCount == 0) {levelmanager.LoadNextLevel();}
	}
}