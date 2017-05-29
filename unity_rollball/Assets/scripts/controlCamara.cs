using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlCamara : MonoBehaviour {


	public GameObject target; 

	void Start () 
	{
		Input.gyro.enabled = true;
	}

	void Update () 
	{
		ApplyGyroRotation ();
	}


	void ApplyGyroRotation()
	{
		target.transform.rotation = Input.gyro.attitude;
		target.transform.Rotate( 0f, 0f, 180f, Space.Self ); // Swap "handedness" of quaternion from gyro.
		target.transform.Rotate( 90f, 280f, 0f, Space.World ); // Rotate to make sense as a camera pointing out the back of your device.
	}


	protected void OnGUI()
	{
		GUI.skin.label.fontSize = Screen.width / 60;

		GUILayout.Label("Orientation: " + Screen.orientation);
		GUILayout.Label("input.gyro.attitude: " + Input.gyro.attitude);
		GUILayout.Label("iphone width/font: " + Screen.width + " : " + GUI.skin.label.fontSize);
	}

}
