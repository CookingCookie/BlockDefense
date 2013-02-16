using UnityEngine;
using System.Collections;

public class CamRotationHorizontal : MonoBehaviour 
{
	private float xRotation = 0f;
	public int maxRotationSpeed = 100000;
	public float sensivityX = 100f;	
	void FixedUpdate () 
	{
		if(Input.GetAxis("Mouse X") != 0)
		{			
			xRotation = Input.GetAxis("Mouse X") * sensivityX;
			if(xRotation > maxRotationSpeed)
				{
					xRotation = maxRotationSpeed;
				}
			if(xRotation < -maxRotationSpeed)
			{
				xRotation = -maxRotationSpeed;
			}
					
			transform.Rotate(Vector3.up, xRotation*Time.deltaTime, Space.World);;
		}		
		else
		{
			xRotation = 0;
		}
	}
}
