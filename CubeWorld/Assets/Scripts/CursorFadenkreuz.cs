using UnityEngine;
using System.Collections;

public class CursorFadenkreuz : MonoBehaviour 
{
    public Texture2D fadenkreuz; 
	private bool fadenkreuzEnabled = true;
	void OnGUI() 
	{
        if(fadenkreuzEnabled)
		{
			GUI.Label(new Rect(Screen.width/2, Screen.height/2, fadenkreuz.width, fadenkreuz.height), fadenkreuz);
		}
    }
	public void SetFadenkreuz()
	{
		if(fadenkreuz)
		{
			fadenkreuzEnabled = false;			
		}
		else
		{
			fadenkreuzEnabled = true;
		}
	}
}