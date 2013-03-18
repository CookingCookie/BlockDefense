using UnityEngine;
using System.Collections;

public class ScrollWheel : MonoBehaviour 
{
	public BlockClass m_blockClass;
	private float wheelScrool;
	private int selectedItem = 0;
    void Update()
	{
		if(wheelScrool != Input.GetAxis("Mouse ScrollWheel"))
		{
			wheelScrool = Input.GetAxis("Mouse ScrollWheel");
			calculateSelectedItem();			
		}
	}
	void calculateSelectedItem()
	{
		if(wheelScrool == -0.1f)
		{
			if(selectedItem == 8)
			{
				selectedItem = 0;				
			}
			else
			{
				selectedItem++;
			}
			m_blockClass.SetActuallSelectedCube(selectedItem);
			
		}
		if(wheelScrool == 0.1f)
		{
			if(selectedItem == 0)
			{
				selectedItem = 8;
			}
			else
			{
				selectedItem--;
			}
			m_blockClass.SetActuallSelectedCube(selectedItem);			
		}
	}
}