using UnityEngine;
using System.Collections;

public class CubeSelection : MonoBehaviour 
{
	public int actuallSelectedCube=0;	
	void Update () 
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
	public int GetSelectedCube()
	{		
		return actuallSelectedCube;
	}
	public void SetSelectedCube(int newSelectedCube)
	{
		actuallSelectedCube = newSelectedCube;
	}
}
