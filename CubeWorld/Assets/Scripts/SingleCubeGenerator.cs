using UnityEngine;
using System.Collections;

public class SingleCubeGenerator : MonoBehaviour 
{	
	public BlockClass m_blockClass;	
	private GameObject m_cubeInstanse;	
	private GameObject m_cube;		
	
	public void CheckGenerateSingleCube(Vector3 cubePos)
	{			
		if(m_blockClass.GetAvailabilityOfCubes())
		{
			GenerateSingleCube(cubePos);			
		}
		else
		{
			print ("No items available.");
		}
	}	
	public void GenerateSingleCube(Vector3 cubePos)
	{
		m_cube = m_blockClass.locateBlock();
		m_cubeInstanse = Instantiate(m_cube) as GameObject;
		m_cubeInstanse.transform.position = cubePos;
	}	
}
