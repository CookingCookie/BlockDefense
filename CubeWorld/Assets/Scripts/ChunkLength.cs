using UnityEngine;
using System.Collections;

public class ChunkLength : MonoBehaviour 
{
	private int[] chunkLength = new int[3];
	void Awake()
	{
		chunkLength[0] = 30;
		chunkLength[1] = 10;
		chunkLength[2] = 30;
	}
	public void SetChunkLength(int axis, int length)
	{
		chunkLength[axis] = length;
	}
	public int GetChunkLength(int axis)
	{
		return chunkLength[axis];
	}
}
