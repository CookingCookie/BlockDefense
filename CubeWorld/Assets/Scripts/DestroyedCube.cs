using UnityEngine;
using System.Collections;

public class DestroyedCube : MonoBehaviour 
{
	public int destroyedItem;	
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	public int SetDestroyedCube(GameObject toDestroyingCube)
	{		
		
		switch (toDestroyingCube.ToString())
		{
			case "DirtCube(Clone) (UnityEngine.GameObject)":
				destroyedItem = 0;
				break;
			case "StoneCube(Clone) (UnityEngine.GameObject)":
				destroyedItem = 1;
				break;
			case "Wooden_PlanksCube(Clone) (UnityEngine.GameObject)":
				destroyedItem = 2;
				break;
			case "Copple_stone(Clone) (UnityEngine.GameObject)":
				destroyedItem = 3;
				break;
			case "Gravel(Clone) (UnityEngine.GameObject)":
				destroyedItem = 4;
				break;
			case "Sand(Clone) (UnityEngine.GameObject)":
				destroyedItem = 5;
				break;
			case "Bedrock(Clone) (UnityEngine.GameObject)":
				destroyedItem = 6;
				break;
			case "Obsidian(Clone) (UnityEngine.GameObject)":
				destroyedItem = 7;
				break;
			case "Brick(Clone) (UnityEngine.GameObject)":
				destroyedItem = 8;
				break;
		}
		print (destroyedItem);
		return destroyedItem;
	}
}
