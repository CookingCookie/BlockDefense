using UnityEngine;
using System.Collections;

public class CamMovement : MonoBehaviour 
{
	int movementSpeed = 5;	
	Vector3 movement = Vector3.zero;
    void Update()
    {	  
		movement = Vector3.zero;	    
	    if (Input.GetKey("w"))
	    movement.z++;
		movementZX();
	    if (Input.GetKey("s"))
	    movement.z--;
		movementZX();
	    if (Input.GetKey("a"))
	    movement.x--;
		movementZX();
	    if (Input.GetKey("d"))
	    movement.x++;
		movementZX();
	    if (Input.GetKey("space"))
	    movement.y++;
		movementY();
		if (Input.GetKey(KeyCode.LeftShift))
	    movement.y--;
		movementY();		
    }
	void movementZX()
	{
		transform.Translate(movement * movementSpeed * Time.deltaTime, Space.Self);		
	}
	/*void movementZXNegativ()
	{
		transform.Translate(-movement * movementSpeed * Time.deltaTime, Space.Self);
		
	}*/
	void movementY()
	{
		transform.Translate(movement * movementSpeed * 2 * Time.deltaTime, Space.World);		
	}	
}

  
