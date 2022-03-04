using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{

    //Get the objects

    public GameObject[] Players;

    public Rigidbody2D[] PlayersRBs;

    public Vector2[] Velocity;

    public GameObject Menu;
    public GameObject PauseObj;

    //Close menu at start

    private void Start()
    {

        Menu.SetActive(false);

    }

    //Open the menu
    
    public void OpenMenu()
    {

        Velocity[0] = PlayersRBs[0].velocity;
        Velocity[1] = PlayersRBs[1].velocity;

        Players[0].GetComponent<Entity>().enabled = false;
        Players[1].GetComponent<Entity>().enabled = false;

        PlayersRBs[0].bodyType = RigidbodyType2D.Static;
        PlayersRBs[1].bodyType = RigidbodyType2D.Static;

        Menu.SetActive(true);

        PauseObj.SetActive(false);

        Debug.Log("Open menu");

    }

    public void CloseMenu()
    {

        PlayersRBs[0].AddForce(Velocity[0]);
        PlayersRBs[1].AddForce(Velocity[1]);

        Players[0].GetComponent<Entity>().enabled = true;
        Players[1].GetComponent<Entity>().enabled = true;

        PlayersRBs[0].bodyType = RigidbodyType2D.Dynamic;
        PlayersRBs[1].bodyType = RigidbodyType2D.Dynamic;

        Menu.SetActive(false);

        PauseObj.SetActive(true);

    }
}
