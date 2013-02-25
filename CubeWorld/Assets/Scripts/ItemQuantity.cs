using UnityEngine;
using System.Collections;

public class ItemQuantity : MonoBehaviour {
	bool itemAvailable = false;	
	int[] itemQuantity = new int[9];
	int maxItemQuantity = 10;
	
	void Start()
	{
		for(int i=0; i<9;i++)
		{
			itemQuantity[i] = 15;
		}
	}		 
	
	public bool GetItemQuantity(int selectedItem)
	{		
		if(itemQuantity[selectedItem] != 0)
		{
			itemAvailable = true;
			itemQuantity[selectedItem]--;
			print (itemQuantity[selectedItem]);
		}
		else
		{
				itemAvailable = false;
		}		
		return itemAvailable;
	}
	public void SetItemQuantity(int selectedItem)
	{
		if(itemQuantity[selectedItem] < maxItemQuantity)
		{
			itemQuantity[selectedItem]++;
		}
	}
}
