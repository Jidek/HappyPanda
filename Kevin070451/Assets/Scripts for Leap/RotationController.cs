using UnityEngine;
using System.Collections;

public class RotationController : MonoBehaviour {

	public float rotationAmount = 1.5f;

	private Quaternion initialRotation;
	private Quaternion currentRotation;

	void Start () {
		initialRotation = transform.rotation;
	}

	void Update () {

		if(Input.GetKey(KeyCode.A)){
			Quaternion cRotation = transform.rotation;
			transform.rotation.Set(cRotation.x, cRotation.y - rotationAmount * Time.deltaTime, cRotation.z, cRotation.w);
			Debug.Log("Trying to turn");
		}
		else if(Input.GetKey(KeyCode.D)){
			Quaternion cRotation = transform.rotation;
			transform.rotation.Set(cRotation.x, cRotation.y + rotationAmount * Time.deltaTime, cRotation.z, cRotation.w);
		}
		
		currentRotation = transform.rotation;


	}

	public float changeInRotation(){
		return Quaternion.Angle(currentRotation, initialRotation);
	}
}
