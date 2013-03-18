using UnityEngine;
using System.Collections;

public class GUIIngameMenu : MonoBehaviour 
{
	public CursorLockAndHide m_cursorLock;
	public GUIToolbar m_GUIToolbar;
	public CursorFadenkreuz m_cursorFadenkreuz;
	public GameObject m_player;
	public GameObject m_cubeClick;
	public GameObject m_cubeGenerator;
	public Texture2D m_backgroundImage;
	private int xPosition = (Screen.width/2)-250;
	private int xLaenge = 500;
	private int yPosition = (Screen.height/2)-25;
	private int yLaenge = 50;
	private bool menuOn = false;	
	public void SetMenuState()
	{
		if(menuOn)
		{
			m_GUIToolbar.SetToolbar();
			m_cursorFadenkreuz.SetFadenkreuz();
			menuOn = false;
			m_player.SetActive(true);
			m_cubeClick.SetActive(true);
			m_cubeGenerator.SetActive(true);			
		}
		else
		{
			m_GUIToolbar.SetToolbar();
			m_cursorFadenkreuz.SetFadenkreuz();
			menuOn = true;
			m_player.SetActive(false);
			m_cubeClick.SetActive(false);
			m_cubeGenerator.SetActive(false);			
		}
	}
	void OnGUI()
	{
		if(menuOn)
		{	
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height), m_backgroundImage);
			if(GUI.Button(new Rect(xPosition, yPosition - 200, xLaenge, yLaenge), "Back to game"))
			{
				m_cursorLock.SetCursorLock();
				SetMenuState();				
			}
			if(GUI.Button(new Rect(xPosition, yPosition - 100, xLaenge, yLaenge), "Save game"))
			{
				
			}
			if(GUI.Button(new Rect(xPosition, yPosition - 0, xLaenge, yLaenge), "Optionen"))
			{
				
			}
			if(GUI.Button(new Rect(xPosition, yPosition + 100, xLaenge, yLaenge), "Back to menu"))
			{
				Application.LoadLevel("GUIMenu");
			}
			if(GUI.Button(new Rect(xPosition, yPosition + 200, xLaenge, yLaenge), "Exit"))
			{
				Application.Quit();	
			}
		}
	}
}
