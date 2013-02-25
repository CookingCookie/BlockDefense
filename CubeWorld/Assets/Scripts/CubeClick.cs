using UnityEngine;
using System.Collections;

public class CubeClick : MonoBehaviour 
{
	public SingleCubeGenerator m_cubeGen;	
	public DestroyedCube m_destroyedCube;
	private Ray m_ray;
	private Camera m_cam;
	private RaycastHit m_hit;
	private float m_distance = 5f;
	private bool m_hitSomething;
	private float timeCheck;
	private Vector3 centerVector = new Vector3(Screen.width/2,Screen.height/2,0);
	
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
			//AddCube(CheckMouseRay());
		}
	}	
	RaycastHit CheckMouseRay()
	{
		m_ray = m_cam.ScreenPointToRay(centerVector);
		if(Physics.Raycast(m_ray,out m_hit, m_distance))
		{
			m_hitSomething = true;
		}
		else
		{
			m_hitSomething = false;
		}
		return m_hit;
	}	
	void RemoveCube(RaycastHit cube)
	{
		if(m_hitSomething)
		{
			Destroy(m_hit.collider.gameObject);
			print (m_hit.collider.gameObject);
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
		//float timeReal = Time.realtimeSinceStartup;		
		if(timeCheck + 0.17F < Time.realtimeSinceStartup)
		{
			timeCheck = Time.realtimeSinceStartup;
			AddCube(CheckMouseRay());
		}
	}
	
}
