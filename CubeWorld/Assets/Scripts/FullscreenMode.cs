using UnityEngine;
using System.Collections;

public class FullscreenMode : MonoBehaviour 
{		
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.F11))		
			Screen.fullScreen = !Screen.fullScreen;
	}	
}
