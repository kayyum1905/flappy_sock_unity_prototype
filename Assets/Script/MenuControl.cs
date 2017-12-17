using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadScene(int level)
	{
		SceneManager.LoadScene(level);
	}
}
