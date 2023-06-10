using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour 
{
    void Update()
    {
        gameObject.transform.Translate(0, -0.3f, 0);
        DestroyObject(gameObject, 1);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Nave")
        {
            Destroy(gameObject);
        }
    }
	
}
