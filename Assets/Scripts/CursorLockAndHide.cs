using UnityEngine;
using System.Collections;

public class CursorLockAndHide : MonoBehaviour 
{
	private bool locked; 
	void Start ()
	{
		Screen.lockCursor = true;
		Screen.showCursor = false;
		locked = false; 
	}
    void Update() 
	{
        if (Input.GetKeyDown("escape"))
		{
			cursorLock();
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
}