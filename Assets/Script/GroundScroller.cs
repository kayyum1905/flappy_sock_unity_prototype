using UnityEngine;
using System.Collections;

public class GroundScroller : MonoBehaviour 
{
	[SerializeField]
	private float tileSizeX;

	[SerializeField]
	private float scrollSpeed;

	private Vector3 startPosition;

	void Start ()
	{
		startPosition = transform.position;

		if(gameObject.tag == "Background")
			scrollSpeed = 0.25f;
		else if(gameObject.tag == "Ground")
			scrollSpeed = 1.6f;

		tileSizeX= 11.6f;;
	}
	
	void FixedUpdate ()
	{
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeX);
		transform.position = startPosition + Vector3.left * newPosition;
	}
}
