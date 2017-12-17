using UnityEngine;
using System.Collections;

public class KillOnExit : MonoBehaviour 
{	

	void OnTriggerExit2D(Collider2D target)
	{
		Destroy(target.gameObject);
	}
}