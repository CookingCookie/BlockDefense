using UnityEngine;
using System.Collections;

public class SingleCubeGenerator : MonoBehaviour 
{
	public CubeSelection m_selectedCube;
	private GameObject m_cubeInstanse;
	public GameObject m_cubeDirt;
	public GameObject m_cubeStone;
	public GameObject m_cubeWooden_Planks;
	public GameObject m_copple_stone;
	public GameObject m_gravel;
	public GameObject m_sand;
	public GameObject m_bedrock;
	public GameObject m_obsidian;
	public GameObject m_brick;
	public int actuallSelectedCube=0;
	public void GenerateSingleCube(Vector3 cubePos)
	{
		actuallSelectedCube = m_selectedCube.GetSelectedCube();
		if(actuallSelectedCube==0)
		{
			m_cubeInstanse = Instantiate(m_cubeDirt) as GameObject;
			m_cubeInstanse.transform.position = cubePos;
		}
		if(actuallSelectedCube==1)
		{
			m_cubeInstanse = Instantiate(m_cubeStone) as GameObject;
			m_cubeInstanse.transform.position = cubePos;
		}
		if(actuallSelectedCube==2)
		{
			m_cubeInstanse = Instantiate(m_cubeWooden_Planks) as GameObject;
			m_cubeInstanse.transform.position = cubePos;
		}
		if(actuallSelectedCube==3)
		{
			m_cubeInstanse = Instantiate(m_copple_stone) as GameObject;
			m_cubeInstanse.transform.position = cubePos;
		}
		if(actuallSelectedCube==4)
		{
			m_cubeInstanse = Instantiate(m_gravel) as GameObject;
			m_cubeInstanse.transform.position = cubePos;
		}
		if(actuallSelectedCube==5)
		{
			m_cubeInstanse = Instantiate(m_sand) as GameObject;
			m_cubeInstanse.transform.position = cubePos;
		}
		if(actuallSelectedCube==6)
		{
			m_cubeInstanse = Instantiate(m_brick) as GameObject;
			m_cubeInstanse.transform.position = cubePos;
		}
		if(actuallSelectedCube==7)
		{
			m_cubeInstanse = Instantiate(m_obsidian) as GameObject;
			m_cubeInstanse.transform.position = cubePos;
		}
		if(actuallSelectedCube==8)
		{
			m_cubeInstanse = Instantiate(m_bedrock) as GameObject;
			m_cubeInstanse.transform.position = cubePos;
		}
	}
	
}
