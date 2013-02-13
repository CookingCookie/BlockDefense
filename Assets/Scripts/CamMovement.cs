using UnityEngine;
using System.Collections;

public class CamMovement : MonoBehaviour 
{
	int movementSpeed = 2;	
	Vector3 movement = Vector3.zero;
	
	//RaycastHit m_hit;
	//GameObject m_player;
	//float m_distance = 5f;
	//bool m_hitSomething;
    void Update()
    {	
		/*if(!m_hitSomething)
		{*/
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
		//}
    }
	void movementZX()
	{
		transform.Translate(movement * movementSpeed * Time.deltaTime, Space.Self);
		//transform.constantForce(movement * movementSpeed * Time.deltaTime, Space.Self);
		//transform.constantForce.force = movement * movementSpeed;
	}
	/*void movementZXNegativ()
	{
		transform.Translate(-movement * movementSpeed * Time.deltaTime, Space.Self);
		
	}*/
	void movementY()
	{
		transform.Translate(movement * movementSpeed * 2 * Time.deltaTime, Space.World);		
	}	
	/*RaycastHit checkColliderRay()
	{	
		Ray m_ray = new Ray(transform.position, transform.forward);		
		if(Physics.Raycast(m_ray,out m_hit, m_distance))
		{
			m_hitSomething = true;
		}
		else
		{
			m_hitSomething = false;
		}
		return m_hit;
	}	*/
	
}

  
