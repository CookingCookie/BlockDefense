using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{	
	float movementSpeed = 4.31f;//Steve's Geschwindigkeit
	RaycastHit m_hit;
	Ray m_ray;
	float m_distance = 1f;
	bool m_hitSomething;
	bool onGround = true;
	
	private JumpControl m_jumpControl;
    void Update()
    {	
		//checkHeight();
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
		if (Input.GetKey("space") /*&& onGround == true*/)
		{		    
			//checkHeight();
			movementUp();
			//m_jumpControl.Jump();
		}
	    if (Input.GetKey(KeyCode.LeftShift))
		{		    
			movementDown();
		}		
    }
	void movementForward()
	{
		transform.Translate( Vector3.forward * movementSpeed * Time.deltaTime, Space.Self);
		//rigidbody.AddForce( Vector3.forward * 50 * Time.deltaTime);
		
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
	void checkHeight()
	{
		m_ray = new Ray(transform.position, -transform.up);
		if(Physics.Raycast(m_ray, m_distance))
		{
			print (m_distance);
			onGround = true;
			//movementUp();
		}
		else
		{
			print ("Ray hat nichts getroffen.");
			onGround = false;
		}
		//Physics.Raycast(m_ray);
		//print (m_ray);
	}
	void movementUp()
	{		
		transform.Translate(Vector3.up * movementSpeed  * Time.deltaTime, Space.World);		
	}	
	void movementDown()
	{		
		transform.Translate(Vector3.down * movementSpeed  * Time.deltaTime, Space.World);
		
	}
	
	public void SetJumpControl(JumpControl jumpC)
	{
		m_jumpControl = jumpC;
	}
}

  
