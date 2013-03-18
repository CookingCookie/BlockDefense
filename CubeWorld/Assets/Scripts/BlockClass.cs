using UnityEngine;
using System.Collections;

public class BlockClass : MonoBehaviour 
{	
	public ItemQuantity m_itemQuantity;
	private GameObject m_cube;
	private int actuallSelectedCube;		
	public GameObject m_cubeDirt;
	public GameObject m_cubeStone;
	public GameObject m_cubeWooden_Planks;
	public GameObject m_copple_stone;
	public GameObject m_gravel;
	public GameObject m_sand;
	public GameObject m_bedrock;
	public GameObject m_obsidian;
	public GameObject m_brick;
	void Update()
	{
		selectCubeByNumbers();
	}
	void selectCubeByNumbers()
	{
		if(Input.GetKeyDown("1"))
			actuallSelectedCube = 0;
		if(Input.GetKeyDown("2"))
			actuallSelectedCube = 1;
		if(Input.GetKeyDown("3"))
			actuallSelectedCube = 2;
		if(Input.GetKeyDown("4"))
			actuallSelectedCube = 3;
		if(Input.GetKeyDown("5"))
			actuallSelectedCube = 4;
		if(Input.GetKeyDown("6"))
			actuallSelectedCube = 5;
		if(Input.GetKeyDown("7"))
			actuallSelectedCube = 6;
		if(Input.GetKeyDown("8"))
			actuallSelectedCube = 7;
		if(Input.GetKeyDown("9"))
			actuallSelectedCube = 8;
	}
	public int GetActuallSelectedCube()
	{
		return actuallSelectedCube;
	}
	public void SetActuallSelectedCube(int newSelectedCube)
	{
		actuallSelectedCube = newSelectedCube;
	}
	public bool GetAvailabilityOfCubes()
	{
		actuallSelectedCube = GetActuallSelectedCube();
		return m_itemQuantity.GetItemQuantity(actuallSelectedCube);
	}
	public int GetIntAvailabilityOfCubes(int selectedItem)
	{		
		return m_itemQuantity.GetIntItemQuantity(selectedItem);
	}
	public void SetAvailabilityOfCubes(int itemQuantity)
	{
		m_itemQuantity.SetItemQuantity(itemQuantity);
	}
	public GameObject locateBlock()
	{
		actuallSelectedCube = GetActuallSelectedCube();		
		return GetBlockName(actuallSelectedCube);
	}
	public GameObject GetBlockName(int blockID)
	{				
		switch (blockID)
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
			m_cube = m_bedrock;			
			break;
		case 7:
			m_cube = m_obsidian;			
			break;
		case 8:
			m_cube = m_brick;			
			break;
		}
		return m_cube;
	}
}
