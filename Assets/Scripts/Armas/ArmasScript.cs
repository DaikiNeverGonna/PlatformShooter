using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmasScript : MonoBehaviour
{
    public GameObject[] Armas;
    ArmasScript AS;

    private GameObject NuevaArmaObj;
    public GameObject Line;

    private void Start()
    {
        AS = GetComponent<ArmasScript>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Weapon")
        {

            NuevaArma(collision.gameObject.GetComponent<Collectable>().C�digoArma);

        }

    }
    public void NuevaArma(int C�digoArma)
    {

        Destroy(NuevaArmaObj);

        NuevaArmaObj = Instantiate(Armas[C�digoArma], transform.position, Quaternion.identity, transform);
            NuevaArmaObj.transform.parent = Line.transform;

    }
}
