using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{	
	float movementSpeed = 4.31f;//Steve's Geschwindigkeit		
    void Update()
    {			
		if (Input.GetKey("w"))
		{		   
			movementForward();
		}
		if (Input.GetKey("s"))
		{		    
			movementBack();
		}
		if (Input.GetKey("a"))
		{		   
			movementLeft();
		}
		if (Input.GetKey("d"))
		{		    
			movementRight();
		}
		if (Input.GetKey("space"))
		{		    
			movementUp();
		}
	    if (Input.GetKey(KeyCode.LeftShift))
		{		    
			movementDown();
		}
    }
	void movementForward()
	{
		transform.Translate( Vector3.forward * movementSpeed * Time.deltaTime, Space.Self);
		
	}
	void movementBack()
	{
		transform.Translate( Vector3.back * movementSpeed * Time.deltaTime, Space.Self);
		
	}
	void movementLeft()
	{
		transform.Translate( Vector3.left * movementSpeed * Time.deltaTime, Space.Self);
		
	}
	void movementRight()
	{
		transform.Translate( Vector3.right * movementSpeed * Time.deltaTime, Space.Self);
		
	}	
	void movementUp()
	{
		transform.Translate(Vector3.up * movementSpeed * 2 * Time.deltaTime, Space.World);		
	}
	void movementDown()
	{		
		transform.Translate(Vector3.down * movementSpeed * 2 * Time.deltaTime, Space.World);		
	}	
}

  
