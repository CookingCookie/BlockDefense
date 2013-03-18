using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{	
	public JumpControl m_jumpControl;
	private float movementSpeed = 4.31f;//Steve's Geschwindigkeit
	private RaycastHit m_hit;	
	//private float m_distance = 1f;
	private float m_colliderEnter = 0.3F;
	private float m_heigtColliderEnter = 0.77509F;
	private Vector3 p1;
	private Vector3 p2;
	Vector3 m_newRotation;
	private int m_blockRotation;
	private float m_angleAlpha;
	//private Vector3 m_transformDirection;
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
		//m_transformDirection = transform.forward;
		if(checkHitBox(transform.forward, 0))
		{
			transform.Translate( Vector3.forward * movementSpeed * Time.deltaTime, Space.Self);			
		}		
	}
	void movementBack()
	{
		//m_transformDirection = -transform.forward;
		if(checkHitBox(-transform.forward, 0))
		{
			transform.Translate( Vector3.back * movementSpeed * Time.deltaTime, Space.Self);
		}		
	}
	void movementLeft()
	{
		//m_transformDirection = -transform.right;
		if(checkHitBox(-transform.right, 0))
		{
			transform.Translate( Vector3.left * movementSpeed * Time.deltaTime, Space.Self);
		}		
	}
	void movementRight()
	{
		//m_transformDirection = transform.right;
		if(checkHitBox(transform.right, 0))
		{
			transform.Translate( Vector3.right * movementSpeed * Time.deltaTime, Space.Self);
		}		
	}		
	void movementUp()
	{			
		//m_transformDirection = -transform.up;
		if(checkHitBox(-transform.up, 1))
		{
			m_jumpControl.SetOnGround(true);
			//print ("onGround");
		}
		else
		{
			m_jumpControl.SetOnGround(false);
			//print ("offGround");
		}
		//transform.Translate(Vector3.up * movementSpeed  * Time.deltaTime, Space.World);		
	}	
	void movementDown()
	{		
		transform.Translate(Vector3.down * movementSpeed  * Time.deltaTime, Space.World);
		
	}	
	bool checkHitBox(Vector3 transformDirection, int moveDirection)
	{
		p1 = new Vector3(transform.position.x,transform.position.y /*- 0.4400F*/, transform.position.z);
		p2 = new Vector3(transform.position.x,transform.position.y + 0.4475F, transform.position.z);
		if (Physics.CapsuleCast(p1, p2, 0.1F, transformDirection, out m_hit, 10))
		{
            //print("m_hit.distance = " + m_hit.distance + " m_hit.normal = " + m_hit.normal);			
			return calculateCheckBox(m_hit, moveDirection);
		}
		else
		{
			return true;
		}		
	}
	bool calculateCheckBox(RaycastHit hit, int moveDirection)
	{
		if(moveDirection == 0)
		{
			/*if(hit.distance < m_colliderEnter)
			{
				calculateAngle(hit);
			}
			
			return true;*/
			if(hit.distance > m_colliderEnter)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		else
		{
			if(hit.distance < m_heigtColliderEnter)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
	void calculateAngle(RaycastHit hit)
	{
		//print ("calculateAngle asugeführt.");
		print("hit.distance = " + hit.distance + " hit.normal = " + hit.normal);
		/*switch(hit.normal)
		{
			case new Vector3(0.0F,0.0F,-1.0F):
				m_blockRotation = 0;
				break;
			case new Vector3(1.0F,0.0F,0.0F):
				m_blockRotation = 90;
				break;
			case new Vector3(0.0F,0.0F,1.0F):
				m_blockRotation = 180;
				break;
			case new Vector3(-1.0F,0.0F,0.0F):
				m_blockRotation = -90;
				break;
		}*/
		/*if(hit.normal == new Vector3(0.0F,0.0F,-1.0F))
		{
			//m_blockRotation = 0;
			print ("vorne");
			if(transform.rotation.eulerAngles.y < 90)
			{
				m_angleAlpha = 90;
			}
			else
			{
				m_angleAlpha = 270;
			}
		}
		if(hit.normal == new Vector3(1.0F,0.0F,0.0F))
		{
			print ("links");
			if(transform.rotation.eulerAngles.y < 270)
			{
				m_angleAlpha = 180;
			}
			else
			{
				m_angleAlpha = 0;
			}
		}
		if(hit.normal == new Vector3(0.0F,0.0F,1.0F))
		{
			print ("hinter");
			if(transform.rotation.eulerAngles.y < 180)
			{
				m_angleAlpha = 90;
			}
			else
			{
				m_angleAlpha = 270;
			}
		}
		if(hit.normal == new Vector3(-1.0F,0.0F,0.0F))
		{
			print ("rechts");
			if(transform.rotation.eulerAngles.y < 90)
			{
				m_angleAlpha = 0;
			}
			else
			{
				m_angleAlpha = 180;
			}
		}*/
		/*if(transform.rotation.eulerAngles.y > 0 && transform.rotation.eulerAngles.y < 90)
   			m_angleAlpha = 90;

		if(transform.rotation.eulerAngles.y > 90 && transform.rotation.eulerAngles.y < 180)
  			m_angleAlpha = 180;
   
		if(transform.rotation.eulerAngles.y > 180 && transform.rotation.eulerAngles.y < 270)
		   	m_angleAlpha = 270;
		   
		if(transform.rotation.eulerAngles.y > 270 && transform.rotation.eulerAngles.y < 360)
		   	m_angleAlpha = 360;*/
		if(hit.normal == new Vector3(0.0F,0.0F,-1.0F))
		{	
			if(transform.rotation.eulerAngles.y > 0 && transform.rotation.eulerAngles.y < 90)
				m_angleAlpha = 90;
				
			if(transform.rotation.eulerAngles.y > 180 && transform.rotation.eulerAngles.y < 270)
				m_angleAlpha = 270;	
		}
		if(hit.normal == new Vector3(1.0F,0.0F,0.0F))
		{	
			if(transform.rotation.eulerAngles.y > 90 && transform.rotation.eulerAngles.y < 180)
				m_angleAlpha = 180;
				
			if(transform.rotation.eulerAngles.y > 270 && transform.rotation.eulerAngles.y < 360)
				m_angleAlpha = 360;	
		}
		if(hit.normal == new Vector3(0.0F,0.0F,1.0F))
		{	
			if(transform.rotation.eulerAngles.y > 0 && transform.rotation.eulerAngles.y < 90)
				//m_angleAlpha = 90;
				m_angleAlpha = 270;
				
			if(transform.rotation.eulerAngles.y > 180 && transform.rotation.eulerAngles.y < 270)
				//m_angleAlpha = 270;
				m_angleAlpha = 90;				
		}
		if(hit.normal == new Vector3(-1.0F,0.0F,0.0F))
		{	
			if(transform.rotation.eulerAngles.y > 90 && transform.rotation.eulerAngles.y < 180)
				//m_angleAlpha = 180;
				m_angleAlpha = 360;
				
			if(transform.rotation.eulerAngles.y > 270 && transform.rotation.eulerAngles.y < 360)
				//m_angleAlpha = 360;	
				m_angleAlpha = 180;
		}
		
		//m_angleAlpha = 90 - (m_blockRotation - transform.rotation.eulerAngles.y);
		//transform.rotation.z += m_angleAlpha;
		m_newRotation = new Vector3(transform.rotation.x,/*transform.rotation.y - */m_angleAlpha, transform.rotation.z);
		transform.Rotate(m_newRotation, Space.World);
		//print("m_angleAlpha = " + m_angleAlpha + " m_newRotation = " + m_newRotation);
	}
}

  
