using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmasScript : MonoBehaviour
{
    public GameObject[] Armas;
    public void NuevaArma(int C�digoArma)
    {

        var NuevaArma = Instantiate(Armas[C�digoArma], transform.position, Quaternion.identity, transform);
            NuevaArma.transform.parent = gameObject.transform;

    }
}
