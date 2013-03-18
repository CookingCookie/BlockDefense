using UnityEngine;
using System.Collections;

public class JumpControl : MonoBehaviour 
{
	public GameObject m_player;
	private Rigidbody m_playerRigidBody;
	private bool m_onGround;
	private bool m_jumpForce;
	//private bool m_jumping;
	private Vector3 m_jumpVel = new Vector3(0,230,0);
	private Vector3 m_gravity = new Vector3(0,-90,0); 
	
	void Start()
	{
		m_playerRigidBody = m_player.GetComponent<Rigidbody>();
		//GetComponent<SphereCollider>().isTrigger = true;
		//m_player.GetComponent<PlayerMovement>().SetJumpControl(this);
		
	}
	
	void FixedUpdate()
	{
		JumpBehaviour();
	}
	
	/*public void Jump()
	{
		m_jumpForce = true;
	}*/
	
	void JumpBehaviour()
	{
		if(m_jumpForce)
		{
			//print ("Versucht Sprung");
			TryJump();
		}
		else
		{
			//print ("Versucht keinen Sprung");
			m_playerRigidBody.AddForce(m_gravity * Time.deltaTime);
		}
	}
	
	void TryJump()
	{
		if(m_onGround)
		{
			m_jumpForce = false;
			//m_jumping = true;
			m_playerRigidBody.velocity += m_jumpVel * Time.deltaTime;
		}
	}
	
	/*void OnTriggerEnter(Collider col)
	{
		m_onGround = true;
		m_jumping = false;
		//print (m_onGround + " OnGround");
	}
	
	void OnTriggerExit(Collider col)
	{
		m_onGround = false;
		//print (m_onGround + " OnGround");
	}*/
	public void SetOnGround(bool onGround)
	{
		if(onGround)
		{
			m_onGround = true;
			m_jumpForce = true;
			//m_jumping = false;
		}
		else
		{
			m_onGround = false;
		}
	}
}
