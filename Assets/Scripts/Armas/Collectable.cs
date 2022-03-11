using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public int C�digoArma;

    ArmasScript ArmasScript;

    private void Start()
    {
        ArmasScript = GameObject.FindGameObjectWithTag("Player1").GetComponent<ArmasScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        ArmasScript.NuevaArma(C�digoArma);

    }
}
