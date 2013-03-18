using UnityEngine;
using System.Collections;
using System.IO;

public class ChunkFileCheck : MonoBehaviour 
{
	public ChunkFileLoader m_chunkFileLoader;
	public ChunkFileGeneration m_chunkFileGeneration;
	private Vector3[] chunksLoaded = new Vector3[10];	
	private int number;
	private bool chunkIsLoaded;
	private bool chunkIsStillLoaded;
	void Start()
	{
		for(int i = 0; i < 10; i++)
		{
			chunksLoaded[i] = new Vector3(0.1F,0.1F,0.1F);
		}
	}
	public void SetChunksNearPlayer(Vector3[] chunksNearPlayer)
	{
		deregisterChunk(chunksNearPlayer);
		for(int i = 0; i < 10; i++)
		{			
			checkChunkFile(chunksNearPlayer[i]);
		}
	}
	public void checkChunkFile(Vector3 chunkVector)
	{
		if(File.Exists(@"" + chunkVector + ".txt"))
		{
			if(!checkChunkLoaded(chunkVector))
			{
				m_chunkFileLoader.loadChunkFile(chunkVector);
				registerChunk(chunkVector);				
			}
		}
		else
		{
			m_chunkFileGeneration.generateChunkFile(chunkVector);
			checkChunkFile(chunkVector);
		}
	}
	bool checkChunkLoaded(Vector3 chunkVector)
	{
		chunkIsLoaded = false;
		for(int i = 0; i < 10; i++)
		{
			if(chunksLoaded[i] == chunkVector)
			{
				chunkIsLoaded = true;
			}
		}
		return chunkIsLoaded;
	}
	void registerChunk(Vector3 chunkVector)
	{
		//müssen noch sortiert werden.
		//der Vector3 kann auch (0,0,0) sein, wird vllt als leer gewertet. GELÖST: Wenn der Vector3 (0.1,0.1,0.1).		
		number = 0;
		while(chunksLoaded[number] != new Vector3(0.1F,0.1F,0.1F) && number < 20)
		{
			number++;	
		}
		if(number >= 20)
		{
			Debug.LogError("Fehler etwas is kaputt!!!");
		}		
		chunksLoaded[number] = chunkVector;
	}
	void deregisterChunk(Vector3[] chunksToCheck)
	{
		//Chunks müssen noch gelöscht werden.
		for(int i = 0; i < 10; i++)
		{
			chunkIsStillLoaded = false;
			for(int j = 0; j < 10; j++)
			{
				if(chunksLoaded[i] == chunksToCheck[j])
				{
					chunkIsStillLoaded = true;
				}
			}
			if(!chunkIsStillLoaded)
			{
				chunksLoaded[i] = new Vector3(0.1F,0.1F,0.1F);
			}
		}
	}
}
