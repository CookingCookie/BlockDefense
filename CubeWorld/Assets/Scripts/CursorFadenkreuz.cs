using UnityEngine;
using System.Collections;

public class CursorFadenkreuz : MonoBehaviour 
{
    public Texture2D fadenkreuz;// = new Texture2D(10, 10);	    
	void OnGUI() 
	{
        GUI.Label(new Rect(Screen.width/2, Screen.height/2, fadenkreuz.width, fadenkreuz.height), fadenkreuz);
    }
}