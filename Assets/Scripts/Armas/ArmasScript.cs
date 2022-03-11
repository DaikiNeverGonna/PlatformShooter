using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmasScript : MonoBehaviour
{
    public GameObject[] Armas;
    public void NuevaArma(int CódigoArma)
    {

        var NuevaArma = Instantiate(Armas[CódigoArma], transform.position, Quaternion.identity, transform);
            NuevaArma.transform.parent = gameObject.transform;

    }
}
