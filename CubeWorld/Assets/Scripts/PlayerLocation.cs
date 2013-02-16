using UnityEngine;
using System.Collections;

public class PlayerLocation : MonoBehaviour 
{
	public CubeGenerator m_ChunkGenerator;
	Vector3 m_playerLocation;
	
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	if(m_playerLocation !=transform.position)
		{
		m_playerLocation = transform.position;
		}
	}
	void calculateChunkCreate()
	{
		//if(m_playerLocation.x > m_ChunkGenerator.)
	}
}
