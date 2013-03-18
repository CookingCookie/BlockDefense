using UnityEngine;
using System.Collections;

public class CubeClick : MonoBehaviour 
{
	public SingleCubeGenerator m_cubeGen;	
	public DestroyedCube m_destroyedCube;
	public BlockClass m_blockClass;
	private Ray m_ray;
	private Camera m_cam;
	private RaycastHit m_hit;
	private float m_maxDistance = 5f;
	private float m_minDistance = 0f;
	private bool m_hitSomething;
	private float timeCheck;
	private Vector3 centerVector = new Vector3(Screen.width/2,Screen.height/2,0);
	private int m_item;	
	void Start () 
	{
		m_cam = Camera.main;		
	}
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			RemoveCube(CheckMouseRay());
		}
		if(Input.GetMouseButton(1))
		{
			timeSinceLastBuildAction();			
		}
	}	
	RaycastHit CheckMouseRay()
	{
		m_ray = m_cam.ScreenPointToRay(centerVector);
		if(Physics.Raycast(m_ray,out m_hit, m_maxDistance) && m_hit.distance >m_minDistance)
		{
			m_hitSomething = true;
		}
		else
		{
			m_hitSomething = false;
		}
		//print ("m_hit = " + m_hit.distance);
		return m_hit;
	}	
	void RemoveCube(RaycastHit cube)
	{
		if(m_hitSomething)
		{
			Destroy(m_hit.collider.gameObject);			
			m_item = m_destroyedCube.SetDestroyedCube(m_hit.collider.gameObject);			
			m_blockClass.SetAvailabilityOfCubes(m_item);
		}
	}	
	void AddCube(RaycastHit cube)
	{
		if(m_hitSomething)
		{
			CalculateNewCubePos(cube);
		}
	}	
	void CalculateNewCubePos(RaycastHit cube)
	{
		Vector3 NewcubePos = m_hit.normal + m_hit.transform.position;		
		m_cubeGen.CheckGenerateSingleCube(NewcubePos);
	}
	void timeSinceLastBuildAction()
	{				
		if(timeCheck + 0.17F < Time.realtimeSinceStartup)
		{
			timeCheck = Time.realtimeSinceStartup;
			AddCube(CheckMouseRay());
		}
	}
	
}
