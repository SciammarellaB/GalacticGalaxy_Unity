using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	
	void Start ()
    {

    }
	
	
	void Update () 
    {
	
	}

    public void Start(string start)
    {
        Application.LoadLevel("Game");
    }
    public void Exit(string exit)
    {
        Application.Quit();
    }
}
