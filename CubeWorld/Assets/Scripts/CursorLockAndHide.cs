using UnityEngine;
using System.Collections;

public class CursorLockAndHide : MonoBehaviour 
{
	public GUIIngameMenu m_GUIMenu;
	private bool locked = false; 
	void Start ()
	{
		//Screen.lockCursor = true;
		//Screen.showCursor = false;
		//locked = false;
		cursorLock();
	}
    void Update() 
	{
        if (Input.GetKeyDown("escape"))
		{
			cursorLock();
			m_GUIMenu.SetMenuState();
		}
	}
	void cursorLock()
	{
		if (locked==true)
		{
			print ("CursorLock Off");
            Screen.lockCursor = false;
			Screen.showCursor = true;
			locked = false;
		}
		else
		{
			print ("CursorLock On");
            Screen.lockCursor = true;
			Screen.showCursor = false;
			locked = true;
		}
	}
	public void SetCursorLock()
	{
		cursorLock();	
	}
}