using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ExtraFunctions : MonoBehaviour {

    public GameControl gControl;
    public NaveScript nScript;
    public float pointsfloat;
    public float bestPointsfloat;
    public float levelShowTime;
    public int level;
    public Text points;
    public Text bestPoints;
    public Text life;
    public Text gOver;
    public Text levelText;
    public AudioClip enemyExplosion;
    	
	void Start ()
    {
        nScript = GameObject.Find("Nave").GetComponent<NaveScript>();
        gControl = GameObject.Find("GameControl").GetComponent<GameControl>();
        Time.timeScale = 1;
        
        
	}
	
	void Update ()
    {
        Levels();

        gControl.AtualPoints = pointsfloat;
        bestPointsfloat = GameControl.control.OldPoints;

        GameOver();
        points.text = "Points:" + pointsfloat.ToString();
        bestPoints.text = "Best:" + bestPointsfloat.ToString();
        life.text = "Life:" + nScript.life.ToString();

        levelText.text = "Level:" + level.ToString();
        
   
	}

    public void Exit(string exit)
    {
        Application.LoadLevel("Menu");
    }


    void GameOver()
    {
        if (nScript.life == 0)
        {
            Time.timeScale = 0;
            gOver.gameObject.SetActive(true);
        }
    }

    void Levels()
    {

        levelShowTime += Time.deltaTime;

        if (levelShowTime > 2)
        {
            levelText.gameObject.SetActive(false);
        }

        if (pointsfloat == 0)
        {
            level = 1;
            levelShowTime = 0;
            levelText.gameObject.SetActive(true);
        }
        
        else if (pointsfloat == 200)
        {
            level = 2;
            levelShowTime = 0;
            levelText.gameObject.SetActive(true);
        }

        else if (pointsfloat == 400)
        {
            level = 3;
            levelShowTime = 0;
            levelText.gameObject.SetActive(true);
        }

        else if (pointsfloat == 600)
        {
            level = 4;
            levelShowTime = 0;
            levelText.gameObject.SetActive(true);
        }

        else if (pointsfloat == 800)
        {
            level = 5;
            levelShowTime = 0;
            levelText.gameObject.SetActive(true);
        }

        else if (pointsfloat == 1000)
        {
            level = 6;
            levelShowTime = 0;
            levelText.gameObject.SetActive(true);
        }

        else if (pointsfloat == 1200)
        {
            level = 7;
            levelShowTime = 0;
            levelText.gameObject.SetActive(true);
        }

        else if (pointsfloat == 1400)
        {
            level = 8;
            levelShowTime = 0;
            levelText.gameObject.SetActive(true);
        }

        else if (pointsfloat == 1600)
        {
            level = 9;
            levelShowTime = 0;
            levelText.gameObject.SetActive(true);
        }

        else if (pointsfloat == 1800)
        {
            level = 10;
            levelShowTime = 0;
            levelText.gameObject.SetActive(true);
        }
    }
}
