using UnityEngine;
using System.Collections;

public class NaveScript : MonoBehaviour {

    public GameObject shoot1;
    public GameObject shootpos;
    public float X;
    public int life;
    public AudioClip[] naveAudios;
    public AudioSource naveAudioSource;
    public float hurtAnimTime;
    public bool AninTimeBool;
   

    public int Idle
    {
        get { return GetComponent<Animator>().GetInteger("Idle"); }
        set { GetComponent<Animator>().SetInteger("hurt", value); }
    }
  
    

	void Start () 
    {
        life = 3;
	}
	
	
	void Update () 
    {

        if (AninTimeBool == true)
        {
            hurtAnimTime += Time.deltaTime;
            Idle = 1;
        }

        if (hurtAnimTime > 1)
        {
            AninTimeBool = false;
            hurtAnimTime = 0;
            Idle = 0;
        }

        X = Input.acceleration.x;

       if (Input.acceleration.x > 0.05f && gameObject.transform.position.x < 2.5f)
        {
            gameObject.transform.Translate(8 * Time.deltaTime * Input.acceleration.x, 0, 0);
        }

       else if (Input.acceleration.x < -0.05f && gameObject.transform.position.x > -2.5f)
        {
            gameObject.transform.Translate((8 *Time.deltaTime*Input.acceleration.x), 0, 0);
        }
        
        for (var i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                shoot1.transform.position = shootpos.transform.position;
                Instantiate(shoot1);
                
            }
        }

    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Inimigos")
        {
            naveAudioSource.clip = naveAudios[0];
            naveAudioSource.Play();
            life -= 1;
            Debug.Log("DanoPorColisao");
        }

        if (c.gameObject.tag == "TiroInimigo")
        {
            naveAudioSource.clip = naveAudios[0];
            naveAudioSource.Play();
            life -= 1;
            Debug.Log("DanoPorTiro");
            AninTimeBool = true;
        }
    }



}
