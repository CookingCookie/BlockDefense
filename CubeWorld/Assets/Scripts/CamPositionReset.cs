using UnityEngine;
using System.Collections;

public class CamPositionReset : MonoBehaviour 
{	
	void Update () 
	{
	if(Input.GetKeyDown("o"))
			positionReset();
	}
	void positionReset()
	{
		print ("Positions reset wurde durchgefuehrt");
		transform.position = new Vector3(5,2,5);
		transform.rotation = Quaternion.identity;
	}
}
