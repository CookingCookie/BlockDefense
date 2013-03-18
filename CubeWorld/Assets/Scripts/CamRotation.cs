using UnityEngine;
using System.Collections;

public class CamRotation : MonoBehaviour 
{		
	private float yRotation = 0f;
	public float sensivity = 100f;
	public float sensivityX = 100f;
	public float sensivityJY = 170f;
	public int maxRotationSpeed = 100000;
	public float threshold = 1f;	
	void FixedUpdate () 	
	{		
		if(Input.GetAxis("Mouse Y") != 0)
		{
			yRotation = Input.GetAxis("Mouse Y") * -sensivity;
			if(yRotation > maxRotationSpeed)
			{
				yRotation = maxRotationSpeed;
			}
			if(yRotation < -maxRotationSpeed)
			{
				yRotation = -maxRotationSpeed;
			}
			
			if(yRotation > 0 && (transform.localEulerAngles.x < 90/*75*/ || transform.localEulerAngles.x > 250/*315*/))
			{
				transform.Rotate(Vector3.right, yRotation*Time.deltaTime, Space.Self);
			}
			
			if(yRotation < 0 && (transform.localEulerAngles.x < 94/*85*/ || transform.localEulerAngles.x > 270/*325*/))
			{
				transform.Rotate(Vector3.right, yRotation*Time.deltaTime, Space.Self);
			}			
		}		
		else
		{
			yRotation = 0;
		}			
	}
		
}