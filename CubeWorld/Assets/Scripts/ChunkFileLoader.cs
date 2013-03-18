using UnityEngine;
using System.Collections;
using System.IO;

public class ChunkFileLoader : MonoBehaviour 
{
	public ChunkLength m_chunkLength;
	public BlockClass m_blockClass;
	private int fileLength;
	private string lineValue;
	private string[] stringValues;
	private float[] axisValues = new float[3];	
	private Vector3 blockVector;
	private GameObject m_cubeInstanse;
	private GameObject m_block;
	public void loadChunkFile(Vector3 chunkVector)
	{
		fileLength = m_chunkLength.GetChunkLength(0) * m_chunkLength.GetChunkLength(1) * m_chunkLength.GetChunkLength(2);
		StreamReader chunkReader = new StreamReader(@"" + chunkVector + ".txt", System.Text.Encoding.Default);		
		for(int i = 0; i < fileLength; i++)
		{
			lineValue = chunkReader.ReadLine();
			lineValue = lineValue.Remove(0, 1);
            stringValues = lineValue.Split(',');
            stringValues[1] = stringValues[1].Remove(0, 1);
            stringValues[2] = stringValues[2].Remove(0, 1);
            stringValues[2] = stringValues[2].Remove(3); 
			axisValues[0] = float.Parse(stringValues[0]);
			axisValues[1] = float.Parse(stringValues[1]);
			axisValues[2] = float.Parse(stringValues[2]);
			int blockID = int.Parse(stringValues[3]);
			blockVector = new Vector3(axisValues[0], axisValues[1], axisValues[2]);
			instantiateBlock(blockVector, blockID);
		}
	}
	void instantiateBlock(Vector3 blockPosition, int blockID)
	{
		m_block = m_blockClass.GetBlockName(blockID);
		m_cubeInstanse = Instantiate(m_block) as GameObject;
		m_cubeInstanse.transform.position = blockPosition;
	}
}
