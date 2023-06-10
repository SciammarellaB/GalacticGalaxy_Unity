using UnityEngine;
using System.Collections;

public class SaveLoad : MonoBehaviour 
{
	public void Save(string save)
	{
		GameControl.control.Save();
	}

	public void Load(string load)
	{
		GameControl.control.Load();
	}
}
