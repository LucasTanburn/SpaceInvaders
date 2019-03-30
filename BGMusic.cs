using UnityEngine;
using System.Collections;

public class BGMusic : MonoBehaviour 
{
	static BGMusic instance = null;

	void Awake()
	{
		if (instance != null)
		{
			Destroy (gameObject);
			print ("Duplicate music player self-destructing");
		} else
		{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}
