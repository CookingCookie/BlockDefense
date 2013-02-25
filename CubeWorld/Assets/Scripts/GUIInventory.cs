using UnityEngine;
using System.Collections;

public class GUIInventory : MonoBehaviour 
{
	public CursorLockAndHide cursorLockAndHide;
	public CubeSelection selectedCube;    	
	int xLaenge = 50;
	int xPosition = (Screen.width/2)-200 /*(xLaenge * 4)*/;	
	int yPosition = 850;
	int yLaenge = 30;
	public Texture2D icon1;
	public Texture2D icon2;
	public Texture2D icon3;
	public Texture2D icon4;
	public Texture2D icon5;
	public Texture2D icon6;
	public Texture2D icon7;
	public Texture2D icon8;
	public Texture2D icon9;
	int[] selectedIcon = new int[9];
	int actuallSelectedCube;
	void Start()
	{
			selectedIcon[actuallSelectedCube] = 0;		
			actuallSelectedCube = selectedCube.GetSelectedCube();
			selectedIcon[actuallSelectedCube] = 10;			
	}
	void Update()
	{		
		if(actuallSelectedCube != selectedCube.GetSelectedCube())
		{
			selectedIcon[actuallSelectedCube] = 0;		
			actuallSelectedCube = selectedCube.GetSelectedCube();
			selectedIcon[actuallSelectedCube] = 10;			
		}			
	}
    void OnGUI() 
	{ 				
	        if (GUI.Button(new Rect(xPosition + (xLaenge * 0), yPosition - selectedIcon[0], xLaenge, yLaenge), icon1))
			{
	            print("Clicked slot1");
			}
			if (GUI.Button(new Rect(xPosition + (xLaenge * 1), yPosition - selectedIcon[1], xLaenge, yLaenge), icon2))
			{
	            print("Clicked slot2");
			}
			if (GUI.Button(new Rect(xPosition + (xLaenge * 2), yPosition - selectedIcon[2], xLaenge, yLaenge), icon3))
			{
	            print("Clicked slot3");
			}
			if (GUI.Button(new Rect(xPosition + (xLaenge * 3), yPosition - selectedIcon[3], xLaenge, yLaenge), icon4))
			{
	            print("Clicked slot4");
			}
			if (GUI.Button(new Rect(xPosition + (xLaenge * 4), yPosition - selectedIcon[4], xLaenge, yLaenge), icon5))
			{
	            print("Clicked slot5");
			}
			if (GUI.Button(new Rect(xPosition + (xLaenge * 5), yPosition - selectedIcon[5], xLaenge, yLaenge), icon6))
			{
	            print("Clicked slot6");
			}
			if (GUI.Button(new Rect(xPosition + (xLaenge * 6), yPosition - selectedIcon[6], xLaenge, yLaenge), icon7))
			{
	            print("Clicked slot7");
			}
			if (GUI.Button(new Rect(xPosition + (xLaenge * 7), yPosition - selectedIcon[7], xLaenge, yLaenge), icon8))
			{
	            print("Clicked slot8");
			}
			if (GUI.Button(new Rect(xPosition + (xLaenge * 8), yPosition - selectedIcon[8], xLaenge, yLaenge), icon9))
			{
	            print("Clicked slot9");
			}		
    }
}