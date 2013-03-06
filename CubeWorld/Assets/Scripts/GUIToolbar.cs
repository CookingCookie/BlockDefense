using UnityEngine;
using System.Collections;

public class GUIToolbar : MonoBehaviour 
{
	public CursorLockAndHide cursorLockAndHide;
	public BlockClass m_blockClass; 
	public Texture2D[] icon = new Texture2D[9];
	private int[] selectedIcon = new int[9];
	private int[] m_itemQuantity = new int[9];
	private int xLaenge = 50;
	private int xPosition = (Screen.width/2)-200 /*(xLaenge * 4)*/;	
	private int xPositionLabel = 18;
	private int yPosition = Screen.height-75/*850*/;
	private int yPositionLabel = 27;
	private int yLaenge = 30;		
	private int actuallSelectedCube;
	private bool toolbarEnabled = true;
	void Start()
	{
			selectedItemOnInventory();		
	}
	void Update()
	{		
		if(actuallSelectedCube != m_blockClass.GetActuallSelectedCube())
		{
			selectedItemOnInventory();	
		}
		for(int i=0; i<9; i++)
		{
			m_itemQuantity[i] = m_blockClass.GetIntAvailabilityOfCubes(i);
		}
	}
	void selectedItemOnInventory()
	{
		selectedIcon[actuallSelectedCube] = 0;		
		actuallSelectedCube = m_blockClass.GetActuallSelectedCube();
		selectedIcon[actuallSelectedCube] = 10;		
	}
    void OnGUI() 
	{ 			
		if(toolbarEnabled)
		{
			for(int i=0; i<9; i++)
			{
				GUI.Button(new Rect(xPosition + (xLaenge * i), yPosition - selectedIcon[i], xLaenge, yLaenge), icon[i]);
				GUI.Label(new Rect(xPosition + (xLaenge * i + xPositionLabel), (yPosition  + yPositionLabel), xLaenge, yLaenge), m_itemQuantity[i].ToString());
			}
		}
    }
	public void SetToolbar()
	{
		if(toolbarEnabled)
		{
			toolbarEnabled = false;
		}
		else
		{
			toolbarEnabled = true;
		}
	}
}