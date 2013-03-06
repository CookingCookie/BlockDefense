using UnityEngine;
using System.Collections;

public class GUIStartMenu : MonoBehaviour 
{	
	public Texture2D m_backgroundImage;
	private int xPosition = (Screen.width/2)-250;
	private int xLaenge = 500;
	private int yPosition = (Screen.height/2)-25;
	private int yLaenge = 50;
	private bool menuOn = true;
	
	void Start () 
	{
		
	}
	
	
	void Update () 
	{
	
	}
	public void SetMenuState()
	{
		if(menuOn)
		{
			menuOn = false;
		}
		else
		{
			menuOn = true;
		}
	}
	void OnGUI()
	{
		if(menuOn)
		{
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height), m_backgroundImage);
			if(GUI.Button(new Rect(xPosition, yPosition - 200, xLaenge, yLaenge), "Play"))
			{					
				Application.LoadLevel("CubeGenerationTest");
			}	
			if(GUI.Button(new Rect(xPosition, yPosition - 100, xLaenge, yLaenge), "Load Level"))
			{					
				
			}
			if(GUI.Button(new Rect(xPosition, yPosition - 0, xLaenge, yLaenge), "Optionen"))
			{
				
			}
			if(GUI.Button(new Rect(xPosition, yPosition + 100, xLaenge, yLaenge), "Exit"))
			{
				Application.Quit();	
			}
		}
	}
}
