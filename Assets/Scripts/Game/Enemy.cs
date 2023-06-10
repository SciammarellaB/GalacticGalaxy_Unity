using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public ExtraFunctions eFun;
    public AudioSource mCamAudio;
    public GameObject shoot1;
    public GameObject shootpos;
    public float shootTime;
    

    


	void Start () 
    {
        eFun = GameObject.Find("Main Camera").GetComponent<ExtraFunctions>();
        mCamAudio = GameObject.Find("Main Camera").GetComponent<AudioSource>();
	}

	
	void Update ()
    {
        

        gameObject.transform.Translate(0, (eFun.level*Time.deltaTime), 0);

        shootTime += (eFun.level*Time.deltaTime)/2;

        if (shootTime > 2 && eFun.level > 1)
        {
            shoot1.transform.position = shootpos.transform.position;
            Instantiate(shoot1);
            shootTime = 0;
        }

        if (gameObject.transform.position.y < -6)
        {
            Destroy(gameObject);
        }
        
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "TiroNave")
        {
            eFun.pointsfloat += 10;
            Destroy(gameObject);
            mCamAudio.clip = eFun.enemyExplosion;
            mCamAudio.Play();
            
        }
    }
       
}
