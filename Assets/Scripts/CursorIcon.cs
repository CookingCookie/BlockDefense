/*using UnityEngine;
using System.Collections;

public class changedCursor : MonoBehaviour 
{
      public Textur2D cursorImage;
     
     
    void Start()
    {
      Screen.showCursor = false;
    }
     
     
    void OnGUI()
    {
      GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 32, 32), cursorImage);
    }
  
}*/
/*using UnityEngine;
using System.Collections;
 
public class CursorIcon : MonoBehaviour {
 
	private float z;
 
	void Start () {
		Screen.showCursor = false;
		z = transform.position.z;
	}
 
	void Update () {
		float x = Input.mousePosition.x / Screen.width;
		float y = Input.mousePosition.y / Screen.height;
		transform.position = new Vector3 (x, y, z);			
	}	
}*/
using UnityEngine;
using System.Collections;

public class CursorIcon : MonoBehaviour 
{
    void Start() 
	{
        Texture2D texture = new Texture2D(128, 128);
        //renderer.material.mainTexture = texture;
        texture.SetPixel(2, 2, Color.green);
        texture.Apply();
		
		
    }
}