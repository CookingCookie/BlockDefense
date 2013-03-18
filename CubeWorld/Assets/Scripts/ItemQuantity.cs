using UnityEngine;
using System.Collections;

public class ItemQuantity : MonoBehaviour 
{
	private bool itemAvailable = false;	
	private int[] itemQuantity = new int[9];
	private int maxItemQuantity = 64;
	
	void Start()
	{
		for(int i=0; i<9;i++)
		{
			itemQuantity[i] = 64;
		}
	}		 
	
	public bool GetItemQuantity(int selectedItem)
	{		
		if(itemQuantity[selectedItem] != 0)
		{
			itemAvailable = true;
			itemQuantity[selectedItem]--;			
		}
		else
		{
				itemAvailable = false;
		}		
		return itemAvailable;
	}
	public int GetIntItemQuantity(int selectedItem)
	{				
		return itemQuantity[selectedItem];
	}
	public void SetItemQuantity(int selectedItem)
	{
		if(itemQuantity[selectedItem] < maxItemQuantity)
		{
			itemQuantity[selectedItem]++;
		}
	}
}
