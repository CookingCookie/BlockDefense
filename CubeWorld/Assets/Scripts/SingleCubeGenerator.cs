using UnityEngine;
using System.Collections;

public class SingleCubeGenerator : MonoBehaviour 
{
	public CubeSelection m_selectedCube;
	public ItemQuantity m_itemQuantity;
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
	private GameObject m_cube;
	public int actuallSelectedCube=0;
	private bool itemAvailable;	
	
	public void CheckGenerateSingleCube(Vector3 cubePos)
	{		
		cubesAvailable();
		if(itemAvailable)
		{
			GenerateSingleCube(cubePos);			
		}
		else
		{
			print ("No items available.");
		}
	}
	void cubesAvailable()
	{
		actuallSelectedCube = m_selectedCube.GetSelectedCube();
		itemAvailable = m_itemQuantity.GetItemQuantity(actuallSelectedCube);
	}	
	public void GenerateSingleCube(Vector3 cubePos)
	{
		actuallSelectedCube = m_selectedCube.GetSelectedCube();		
		switch (actuallSelectedCube)
		{
		case 0:
			m_cube = m_cubeDirt;			
			break;
		case 1:
			m_cube = m_cubeStone;			
			break;
		case 2:
			m_cube = m_cubeWooden_Planks;			
			break;
		case 3:
			m_cube =m_copple_stone;			
			break;
		case 4:
			m_cube = m_gravel;			
			break;
		case 5:
			m_cube = m_sand;			
			break;
		case 6:
			m_cube = m_brick;			
			break;
		case 7:
			m_cube = m_obsidian;			
			break;
		case 8:
			m_cube = m_bedrock;			
			break;
		}
		m_cubeInstanse = Instantiate(m_cube) as GameObject;
		m_cubeInstanse.transform.position = cubePos;
	}	
}
