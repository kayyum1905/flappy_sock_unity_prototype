using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour 
{
	
	public GameObject tapButton;


	void Awake () 
	{

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GameStarted()
	{
		if(tapButton != null)
			tapButton.SetActive(false);
	}
}
