using UnityEngine;
using System.Collections;

public class FootMover : MonoBehaviour 
{

	private FootMover floor;
	private Rigidbody2D rb;

	[SerializeField]
	private float speed;
	
	void Start () 
	{
		speed = 75f;
		rb = gameObject.AddComponent<Rigidbody2D>();
		rb.gravityScale = 0f;
		rb.isKinematic = true;	
	}
	
	void FixedUpdate () 
	{
		Vector3 movement = new Vector3( -speed, 0 , 0);
		rb.velocity = movement * Time.deltaTime ;
	}
}
