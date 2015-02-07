using UnityEngine;
using System.Collections;
using Leap;

public class NormalVectorChecker : FingerCountChecker {
	public HandController hand;

	private TextMesh text;
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent(typeof(TextMesh)) as TextMesh;
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Normal Vector: " + hand.getNormal();
	}
}