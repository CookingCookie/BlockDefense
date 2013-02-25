using UnityEngine;
using System.Collections;

public class CamRotation : MonoBehaviour 
{	
	//private float xRotation = 0f;
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
			
			/*if(transform.localEulerAngles.x < 315 && transform.localEulerAngles.x >85)
			{
				transform.localEulerAngles = new Vector3(0,0,0);
			}*/
		}		
		else
		{
			yRotation = 0;
		}	
		/*if(Input.GetAxis("Mouse X") != 0)
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
		}*/
	}
		
}