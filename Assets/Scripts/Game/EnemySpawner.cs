using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    float posX;
    public float spTimeMulti;
    public float SpawnTime;
    public GameObject Enemy;

   	void Start () 
    {
        spTimeMulti = 1.2f;
	}
	
	
	void Update ()
    {
        posX = Random.Range(-2.5f, 2.5f);
        gameObject.transform.position = new Vector3(posX, 5.5f, 0);

        SpawnTime += spTimeMulti * Time.deltaTime;

        if (SpawnTime >= 1)
        {
            SpawnTime = 0;
            Enemy.transform.position = gameObject.transform.position;
            Instantiate(Enemy);
        }
       
	}
}
