using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour 
{

	public static GameControl control;
    public float AtualPoints;
	public float OldPoints;

	void Awake () 
	{
		if(control == null)
		{
			DontDestroyOnLoad(gameObject);
			control = this;
		}
		else if(control != this)
		{
			Destroy(gameObject);
		}
	}

	public void Save()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
		PlayerData data = new PlayerData();
        if (AtualPoints > OldPoints)
		{
            data.savedScore = AtualPoints;
		}

        if (AtualPoints < OldPoints)
        {
            data.savedScore = OldPoints;
        }
		
        bf.Serialize(file,data);
		file.Close();

        Debug.Log("Saving");
	}

	public void Load()
	{
		if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat",FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            OldPoints = data.savedScore;
            
            Debug.Log("Loading");
		}
	}

	[Serializable]
	class PlayerData
	{
		public float savedScore;
	}
}
