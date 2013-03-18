using UnityEngine;
using System.Collections;

public class ChunksNearPlayer : MonoBehaviour 
{
	public ActualPlayerChunk m_actualPlayerChunk;
	public ChunkFileCheck m_chunkFileCheck;
	private Vector3[] chunksNearPlayer = new Vector3[10];
	private Vector3 actualPlayerChunk;
	private Vector3 playerChunk;
	void Update () 
	{
		actualPlayerChunk = m_actualPlayerChunk.GetActualPlayerChunk();
		if(actualPlayerChunk != playerChunk)
		{
			playerChunk = actualPlayerChunk;
			chunksToLoad(m_actualPlayerChunk.GetActualPlayerChunk());
		}
	}	
	void chunksToLoad(Vector3 chunkVector)
	{		
		chunksNearPlayer[0] = chunkVector - new Vector3(-30,0,30);
		chunksNearPlayer[1] = chunkVector - new Vector3(0,0,30);
		chunksNearPlayer[2] = chunkVector - new Vector3(30,0,30);
		chunksNearPlayer[3] = chunkVector - new Vector3(-30,0,0);
		chunksNearPlayer[4] = chunkVector - new Vector3(0,0,0);
		chunksNearPlayer[5] = chunkVector - new Vector3(30,0,0);
		chunksNearPlayer[6] = chunkVector - new Vector3(-30,0,-30);
		chunksNearPlayer[7] = chunkVector - new Vector3(0,0,-30);
		chunksNearPlayer[8] = chunkVector - new Vector3(30,0,-30);
		chunksNearPlayer[9] = chunkVector - new Vector3(0,-10,0);
		m_chunkFileCheck.SetChunksNearPlayer(chunksNearPlayer);
	}
}
