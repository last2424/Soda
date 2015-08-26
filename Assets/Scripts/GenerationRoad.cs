using UnityEngine;
using System.Collections;

public class GenerationRoad : MonoBehaviour {

	public int countRoad;
	public Transform player;
	public GameObject[] roads = new GameObject[9];
	public GameObject[] roadsHype;
	public int nextRoad;
	public float pointCreate;

	void Start () {
		countRoad = Random.Range(4, 9);
		roadsHype = new GameObject[countRoad];
		for (int i = 0; i < countRoad; i++) {
			nextRoad = Random.Range (0, 10);
			roadsHype[i] = roads[nextRoad];
			Object.Instantiate(roads[nextRoad], new Vector3((player.position.x+5.18f)*i, player.position.y, 0), new Quaternion());
		}
		pointCreate = (roadsHype[0].transform.localScale.x);
	}
	

	void Update () {
		if (player.position.x < pointCreate && player.position.x > pointCreate - 1) {
			countRoad = Random.Range(4, 9);
			for (int i = 0; i < countRoad; i++) {
				nextRoad = Random.Range (0, 10);
				Object.Instantiate(roads[nextRoad], new Vector3((player.position.x+5.18f)*i, player.position.y, 0), new Quaternion());
			}
		}
	}
}