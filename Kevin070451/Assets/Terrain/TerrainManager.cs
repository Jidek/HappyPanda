using UnityEngine;
using System.Collections;

public class TerrainManager : MonoBehaviour {

	public Terrain terrainPrefab;
	public float MAX_X;
	public float MAX_Z;
	//public float LIGHT_DIST;
	private Terrain terrainNW;
	private Terrain terrainN;
	private Terrain terrainNE;
	private Terrain terrainW;
	private Terrain terrainC;
	private Terrain terrainE;
	private Terrain terrainSW;
	private Terrain terrainS;
	private Terrain terrainSE;

	void Start () {
		terrainNW = Instantiate(terrainPrefab) as Terrain;
		terrainNW.gameObject.transform.position = new Vector3(-MAX_X, 0, MAX_Z);

		terrainN = Instantiate(terrainPrefab) as Terrain;
		terrainN.gameObject.transform.position = new Vector3(0, 0, MAX_Z);

		terrainNE = Instantiate(terrainPrefab) as Terrain;
		terrainNE.gameObject.transform.position = new Vector3(MAX_X, 0, MAX_Z);

		terrainW = Instantiate(terrainPrefab) as Terrain;
		terrainW.gameObject.transform.position = new Vector3(-MAX_X, 0, 0);

		terrainC = Instantiate(terrainPrefab) as Terrain;
		terrainC.gameObject.transform.position = new Vector3(0, 0, 0);

		terrainE = Instantiate(terrainPrefab) as Terrain;
		terrainE.gameObject.transform.position = new Vector3(MAX_X, 0, 0);

		terrainSW = Instantiate(terrainPrefab) as Terrain;
		terrainSW.gameObject.transform.position = new Vector3(-MAX_X, 0, -MAX_Z);

		terrainS = Instantiate(terrainPrefab) as Terrain;
		terrainS.gameObject.transform.position = new Vector3(0, 0, -MAX_Z);

		terrainSE = Instantiate(terrainPrefab) as Terrain;
		terrainSE.gameObject.transform.position = new Vector3(MAX_X, 0, -MAX_Z);
	}

	void Update () {
		/*
		terrainNW.activeTerrain.basemapDistance = LIGHT_DIST;
		terrainN.activeTerrain.basemapDistance = LIGHT_DIST;
		terrainNE.activeTerrain.basemapDistance = LIGHT_DIST;
		terrainW.activeTerrain.basemapDistance = LIGHT_DIST;
		terrainC.activeTerrain.basemapDistance = LIGHT_DIST;
		terrainE.activeTerrain.basemapDistance = LIGHT_DIST;
		terrainSW.activeTerrain.basemapDistance = LIGHT_DIST;
		terrainS.activeTerrain.basemapDistance = LIGHT_DIST;
		terrainSE.activeTerrain.basemapDistance = LIGHT_DIST;
		*/
	}
}
