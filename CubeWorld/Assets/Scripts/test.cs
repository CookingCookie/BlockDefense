using UnityEngine;
using System.Collections;

public class test : MonoBehaviour 
{
	public ChunkFileGeneration m_chunkFileGeneration;
	public ChunkFileLoader m_chunkFileLoader;
	// Use this for initialization
	void Start () 
	{
		m_chunkFileGeneration.generateChunkFile(new Vector3(0,-10,0));
		m_chunkFileLoader.loadChunkFile(new Vector3(0,-10,0));
		//m_chunkFileGeneration.generateChunkFile(new Vector3(30,-10,0));
		//m_chunkFileLoader.loadChunkFile(new Vector3(30,-10,0));
	}	
	
}
