using UnityEngine;
using System.Collections;

public class CameraMoving : MonoBehaviour {
	public Transform player;
	public float playerDistance = 81;
	void Start () {
	
	}

	void Update () {
		PlayerAnimation pa = player.GetComponent<PlayerAnimation> ();
		if (pa.Game) {
			if (pa.maxSpeed == 2) {
				if (playerDistance < 81)
					playerDistance += 1 * Time.deltaTime;
			}
			if (pa.maxSpeed == 4) {
				if (playerDistance < 79)
					playerDistance += 1 * Time.deltaTime;
				if (playerDistance > 79)
					playerDistance -= 1 * Time.deltaTime;

			}
			if (pa.maxSpeed == 6) {
				if (playerDistance < 77)
					playerDistance += 1 * Time.deltaTime;
				if (playerDistance > 77)
					playerDistance -= 1 * Time.deltaTime;
				
			}
			if (pa.maxSpeed == 8) {
				if (playerDistance < 75)
					playerDistance += 1 * Time.deltaTime;
				if (playerDistance > 75)
					playerDistance -= 1 * Time.deltaTime;
				
			}
			if (pa.maxSpeed == 10) {
				if (playerDistance < 73)
					playerDistance += 1 * Time.deltaTime;
				if (playerDistance > 73)
					playerDistance -= 1 * Time.deltaTime;
				
			}
			transform.position = new Vector3 (player.position.x + playerDistance, transform.position.y, transform.position.z);
		}
	}
}
