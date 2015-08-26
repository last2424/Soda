using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour
{
	public float maxSpeed = 2f; 
	
	private bool isFacingRight = true;
	private Animator anim;
	
	public float StartGameTimer = 6;
	public bool Game = false;
	public bool Keyboard = false;

	public float fuel = 100;
	public float Timerfuel = 1;
	
	private void Start()
	{
		anim = GetComponent<Animator>();
	}
	
	private void FixedUpdate()
	{

		if (StartGameTimer > -1)
			StartGameTimer -= Time.deltaTime;
		else if (StartGameTimer < 0)
			Game = true;
		Keyboard = true;


		
		if (Game == true) {
			float move = 2.0f;

			if (fuel <= 0){
				move = 0;
				Keyboard = false;
			}

			if(Timerfuel < 1){
				Timerfuel -= Time.deltaTime;
			}else if(fuel > 0) {
				fuel -= 0.01f;
				Timerfuel = 1;
			}



			anim.SetFloat ("Speed", Mathf.Abs (move));
			
			if (Input.GetKeyDown (KeyCode.RightArrow))
				maxSpeed += 2f;
			else if (Input.GetKeyDown (KeyCode.LeftArrow))
				maxSpeed -= 2f;
			
			if (maxSpeed > 10f)
				maxSpeed = 10f;
			if (maxSpeed < 2f)
				maxSpeed = 2f;

			if(Keyboard == true) {
			if (Input.GetKey (KeyCode.UpArrow))
				transform.Translate (new Vector2 (move * maxSpeed * Time.deltaTime, 3f * Time.deltaTime));
			else if (Input.GetKey (KeyCode.DownArrow))
				transform.Translate (new Vector2 (move * maxSpeed * Time.deltaTime, -3f * Time.deltaTime));
			else
				transform.Translate (new Vector2 (move * maxSpeed * Time.deltaTime, 0f * Time.deltaTime));
			}
		}
	}
	
	private void Flip()
	{
		isFacingRight = !isFacingRight;
		
		Vector3 theScale = transform.localScale;
		
		theScale.x *= -1;
		
		transform.localScale = theScale;
	}
}