using UnityEngine;
using System.Collections;

public class BackGround : MonoBehaviour
{

    public GameObject Bg1;
    public GameObject Bg2;

    void Update()
    {
        
        Bg1.transform.Translate(0, -(1*Time.deltaTime), 0);
        Bg2.transform.Translate(0, -(1 * Time.deltaTime), 0);

        if(Bg1.transform.position.y <= -10)
        {
            Bg1.transform.position = new Vector3(0, 10.24f, 0);
        }

        if (Bg2.transform.position.y <= -10)
        {
            Bg2.transform.position = new Vector3(0, 10.24f, 0);
        }
    }




}
