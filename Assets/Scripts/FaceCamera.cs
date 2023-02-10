using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{
	Camera cameraToLookAt;

	// Use t$$anonymous$$s for initialization 
	void Start()
	{
		cameraToLookAt=Camera.main;

	}

	// Update is called once per frame 
	void LateUpdate()
	{
		transform.LookAt(cameraToLookAt.transform);
		transform.rotation=Quaternion.LookRotation(cameraToLookAt.transform.forward);
	}
}
