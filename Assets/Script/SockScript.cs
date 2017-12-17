using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SockScript : MonoBehaviour 
{
	public static SockScript instance;

	public bool isAlive;

	private Rigidbody2D rb;
	private Button flapButton;
	private float bounceSpeed;

	private bool didFlap;

	void Awake () 
	{
		rb = GetComponent<Rigidbody2D>();
		rb.isKinematic = true;

		bounceSpeed = 4.25f;

		if(instance == null)
		{
			instance = this;
		}

		isAlive = true;

		flapButton = GameObject.FindGameObjectWithTag("FlapButton").GetComponent<Button>();
		flapButton.onClick.AddListener(() => FlapTheSock());
	}



	void FixedUpdate () 
	{
		if(isAlive)
		{
			if(rb.velocity.y >= 0)
			{
				transform.rotation = Quaternion.Euler(0 , 0 , -6f);
			} 
			else 
			{
				float angle = -20f;
				angle = Mathf.Lerp(0 , -45 , -rb.velocity.y / 9f);
				transform.rotation = Quaternion.Euler(0 , 0 , angle);
			}
		}

		if(didFlap)
		{
			didFlap = false;
			rb.velocity = new Vector2 (0 , bounceSpeed);
		}
	}

	public void FlapTheSock()
	{
		didFlap = true;
		rb.isKinematic = false;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Foot")
			print("Collided with a foot!");
	}
}


