using UnityEngine;
using System.Collections;

public class LeapPlayerController : MonoBehaviour {

	public HandController palmPilot;

	public float forceMagnitude;

	private Vector3 lastForce = Vector3.zero;
	private Vector3 currentForce, deltaForce;

	void FixedUpdate () {
		currentForce = Vector3.Scale (new Vector3 (forceMagnitude, forceMagnitude, forceMagnitude), palmPilot.getNormal ());
		deltaForce = currentForce - lastForce;
		Debug.Log("Normal Vector is: " + palmPilot.getNormal());
		rigidbody.AddForce (deltaForce);//, ForceMode.Acceleration);
	}
}
