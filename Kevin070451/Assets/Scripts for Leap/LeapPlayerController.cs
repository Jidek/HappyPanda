using UnityEngine;
using System.Collections;

public class LeapPlayerController : MonoBehaviour {

	public HandController palmPilot;
	public RotationController playerController;

	public float forceBaseMagnitude;
	public float xMultiplier, yMultiplier, zMultiplier;

	private Vector3 lastForce = Vector3.zero;
	private Vector3 currentForce, deltaForce, inputForce;
	private float forceMagnitude, height;

	void FixedUpdate () {
		height = palmPilot.getHeight ();
		forceMagnitude = forceBaseMagnitude / ((height * height) + 1);
		inputForce = translate (palmPilot.getNormal (), playerController.changeInRotation ());
		currentForce = Vector3.Scale (new Vector3 (xMultiplier * forceMagnitude, yMultiplier * forceMagnitude, zMultiplier * forceMagnitude), inputForce);
		deltaForce = currentForce - lastForce;
		Debug.Log("Normal Vector is: " + palmPilot.getNormal());
		Debug.Log ("Height is: " + palmPilot.getHeight ());
		rigidbody.AddForce (deltaForce);//, ForceMode.Acceleration);
	}

	private Vector3 translate(Vector3 normalVector, float angle){
		return new Vector3 (normalVector.z * Mathf.Sin (angle) + normalVector.x * Mathf.Cos (angle), normalVector.y, normalVector.z * Mathf.Cos (angle) - normalVector.x * Mathf.Sin (angle));
	}
}
