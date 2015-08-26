using UnityEngine;
using System.Collections;

public class BlockMove : MonoBehaviour {

	public float ms;
	public Transform block;
	float speed;

	void Update () {
		PlayerAnimation pA = block.GetComponent<PlayerAnimation> ();
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		ms = pA.maxSpeed;
		if (pA.Game == true) {
			//if(ms==2f||ms==4f||ms==6f||ms==8f||ms==10f
			transform.Translate((ms*2)*Time.deltaTime,0f,0f);
		}
	}
}
