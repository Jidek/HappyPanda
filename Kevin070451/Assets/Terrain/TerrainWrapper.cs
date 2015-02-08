using UnityEngine;
using System.Collections;

public class TerrainWrapper : MonoBehaviour {
	
	public GameObject player;
	public float TERRAIN_SIZE;
	private Vector3 newPos;
	
	void FixedUpdate () {
		if (player.transform.position.x > TERRAIN_SIZE) {
			if (player.transform.position.z > TERRAIN_SIZE)
				newPos = new Vector3(
					player.transform.position.x - TERRAIN_SIZE,
					player.transform.position.y,
					player.transform.position.z - TERRAIN_SIZE
					);
			else if (player.transform.position.z < 0)
				newPos = new Vector3(
					player.transform.position.x - TERRAIN_SIZE,
					player.transform.position.y,
					player.transform.position.z + TERRAIN_SIZE
					);
			else
				newPos = new Vector3(
					player.transform.position.x - TERRAIN_SIZE,
					player.transform.position.y,
					player.transform.position.z
					);
		}
		else if (player.transform.position.x < 0) {
			if (player.transform.position.z > TERRAIN_SIZE)
				newPos = new Vector3(
					player.transform.position.x + TERRAIN_SIZE,
					player.transform.position.y,
					player.transform.position.z - TERRAIN_SIZE
					);
			else if (player.transform.position.z < 0)
				newPos = new Vector3(
					player.transform.position.x + TERRAIN_SIZE,
					player.transform.position.y,
					player.transform.position.z + TERRAIN_SIZE
					);
			else
				newPos = new Vector3(
					player.transform.position.x + TERRAIN_SIZE,
					player.transform.position.y,
					player.transform.position.z
					);
		}
		else {
			if (player.transform.position.z > TERRAIN_SIZE)
				newPos = new Vector3(
					player.transform.position.x,
					player.transform.position.y,
					player.transform.position.z - TERRAIN_SIZE
					);
			else if (player.transform.position.z < 0)
				newPos = new Vector3(
					player.transform.position.x,
					player.transform.position.y,
					player.transform.position.z + TERRAIN_SIZE
					);
			else
				newPos = new Vector3(
					player.transform.position.x,
					player.transform.position.y,
					player.transform.position.z
					);
		}
		player.transform.position = newPos;
	}
}
