using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeGenerator : MonoBehaviour 
{
	public SingleCubeGenerator m_cubeGen;	
	public int m_mapXStart;
	public int m_mapXEnd;
	public int m_mapYStart;
	public int m_mapYEnd;	
	public int m_mapZStart;
	public int m_mapZEnd;	
	private Vector3 m_cubePos;
	
	void Start () 
	{
		GenerateCubes();
	}	
	//Map generation 
	void GenerateCubes()
	{
		//Chunk algorithm
		for(int i = 0; i < m_mapXEnd; i++)
		{
			m_cubePos.x ++;
			for(int j = 0; j < m_mapZEnd; j++)
			{
				m_cubePos.z ++;
				for(int k = 0; k < m_mapYEnd; k++)
					{
						m_cubePos.y --;					
						
						m_cubeGen.GenerateSingleCube(m_cubePos);						
					}
					m_cubePos.y = 0;
			}
			m_cubePos.z = 0;
		}
		m_cubePos.x = 0;
	}
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Z))
		{
			CubeGenerationNegativY();
		}
		if(Input.GetKeyDown(KeyCode.U))
		{
			CubeGenerationNegativX();
		}
	}
	//Chunk generation
	public void CubeGenerationNegativY()
	{
		print ("z gedrückt");
		m_mapYStart = m_mapYEnd;
		m_cubePos.y = -m_mapYStart;
		m_mapYEnd = m_mapYEnd + 5;
		print("m_mapYnew=" + m_mapYStart + ". m_mapY=" + m_mapYEnd + ".");
		//Chunk algorithm
			for(int i = 0; i < m_mapXEnd; i++)
			{
				m_cubePos.x ++;
				for(int j = 0; j < m_mapZEnd; j++)
				{
					m_cubePos.z ++;				
					for(int k = m_mapYStart; k < m_mapYEnd; k++)
					{
						m_cubePos.y --;						
						m_cubeGen.GenerateSingleCube(m_cubePos);						
					}
					m_cubePos.y = -m_mapYStart;
				}
				m_cubePos.z = 0;				
			}				
		m_cubePos.x = 0;
	}
	public void CubeGenerationNegativX()
	{
		print ("U gedrückt");
		//m_mapXStart = m_mapXEnd;
		//m_cubePos.x = -m_mapXStart;
		//m_mapXEnd = m_mapXEnd + 32;
		//print("m_mapXnew=" + m_mapXStart + ". m_mapX=" + m_mapXEnd + ".");
		//Chunk algorithm
			for(int i = m_mapXStart; i < m_mapXEnd; i++)
			{
				m_cubePos.x --;
				for(int j = 0; j < m_mapZEnd; j++)
				{
					m_cubePos.z ++;				
					for(int k = 0; k < m_mapYEnd; k++)
					{
						m_cubePos.y --;						
						m_cubeGen.GenerateSingleCube(m_cubePos);						
					}
					m_cubePos.y = 0;
				}
				m_cubePos.z = 0;				
			}				
		m_cubePos.x = -m_mapXStart;	
		m_mapXStart = m_mapXEnd;
		m_cubePos.x = -m_mapXStart;
		m_mapXEnd = m_mapXEnd + 32;
		print("m_mapXnew=" + m_mapXStart + ". m_mapX=" + m_mapXEnd + ".");
	}	
}
