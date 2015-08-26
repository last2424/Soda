using UnityEngine;
using System.Collections;

public class TextStart : MonoBehaviour {
	public TextMesh tm;
	public Transform player;



	void Update () {
		PlayerAnimation pA = player.GetComponent<PlayerAnimation> ();
		if (pA.StartGameTimer <= 6 && pA.StartGameTimer >= 4)
			tm.text = "3";
		if (pA.StartGameTimer <= 4 && pA.StartGameTimer >= 2)
			tm.text = "2";
		if (pA.StartGameTimer <= 2 && pA.StartGameTimer >= 0)
			tm.text = "1";
		if (pA.StartGameTimer <= 0) 
			tm.text = "GO!";
		if (pA.StartGameTimer <= -1)
			tm.text = "";

	}
}
