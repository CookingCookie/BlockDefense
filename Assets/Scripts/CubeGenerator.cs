using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeGenerator : MonoBehaviour 
{
	public int m_mapX;
	public int m_mapYEnd;
	public int m_mapYStart;	
	public int m_mapZ;		
	public GameObject m_cubePrefab;
	private Vector3 m_cubePos;
	private GameObject m_cubeInstanse;	
	
	void Start () 
	{
		GenerateCubes();
	}
	
	void GenerateCubes()
	{
		for(int i = 0; i < m_mapX; i++)
		{
			m_cubePos.x ++;
			for(int j = 0; j < m_mapZ; j++)
			{
				m_cubePos.z ++;
				GenerateSingleCube(m_cubePos);
			}
			m_cubePos.z = 0;
		}
		m_cubePos.x = 0;
	}
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Z))
		{
			CubeGenerationY();
		}
		if(Input.GetKeyDown(KeyCode.U))
		{
			CubeGenerationXZ();
		}
	}
	
	public void GenerateSingleCube(Vector3 cubePos)
	{
		m_cubeInstanse = Instantiate(m_cubePrefab) as GameObject;
		m_cubeInstanse.transform.position = cubePos;
	}
	public void CubeGenerationY()
	{
		print ("z gedrückt");		
			for(int i = 0; i < m_mapX; i++)
			{
				m_cubePos.x ++;
				for(int j = 0; j < m_mapZ; j++)
				{
					m_cubePos.z ++;				
					for(int k = m_mapYStart; k < m_mapYEnd; k++)
					{
						m_cubePos.y --;
						GenerateSingleCube(m_cubePos);						
					}
					m_cubePos.y = 0;
				}
				m_cubePos.z = 0;				
			}
		print("m_mapYnew=" + m_mapYStart + ". m_mapY=" + m_mapYEnd + ".");		
		m_mapYStart = m_mapYStart + 5;
		m_mapYEnd = m_mapYEnd + 5;		
		m_cubePos.x = 0;
	}
	public void CubeGenerationXZ()
	{
				
	}
}
