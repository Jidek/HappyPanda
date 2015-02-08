using UnityEngine;
using System.Collections;

public class LeapPlayerController : MonoBehaviour {

	public HandController palmPilot;

	public float forceBaseMagnitude;
	public float xMultiplier, yMultiplier, zMultiplier;

	private Vector3 lastForce = Vector3.zero;
	private Vector3 currentForce, deltaForce;
	private float forceMagnitude, height;

	void FixedUpdate () {
		height = palmPilot.getHeight ();
		forceMagnitude = forceBaseMagnitude / ((height * height) + 1);
		currentForce = Vector3.Scale (new Vector3 (xMultiplier * forceMagnitude, yMultiplier * forceMagnitude, zMultiplier * forceMagnitude), palmPilot.getNormal ());
		deltaForce = currentForce - lastForce;
		Debug.Log("Normal Vector is: " + palmPilot.getNormal());
		Debug.Log ("Height is: " + palmPilot.getHeight ());
		rigidbody.AddForce (deltaForce);//, ForceMode.Acceleration);
	}
}
