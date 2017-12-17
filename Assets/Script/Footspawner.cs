using UnityEngine;
using System.Collections;

public class Footspawner : MonoBehaviour 
{

	public GameObject[] foot;
	
	private float startTime;

	[SerializeField]
	private float waitTime;
	private string prevFloorName;

	void Awake () 
	{
		startTime = 0.5f;
		waitTime = 2.8f;
	}
	
	void Start()
	{
		StartCoroutine((SpawnFloor()));
	}
	
	IEnumerator SpawnFloor()
	{
		yield return new WaitForSeconds(startTime);
		
		while (true)
		{
			int i = Random.Range(0 , foot.Length);
//			if(foot[i].name != prevFloorName)
				Instantiate(foot[i] , transform.position , Quaternion.identity );
//			else if(foot[i].name == prevFloorName)
//			{
//				Instantiate(foot[Random.Range(0 , foot.Length)] , transform.position , Quaternion.identity );
//			}
//			prevFloorName = foot[i].name;
			yield return new WaitForSeconds(waitTime);
		}
	}
}
