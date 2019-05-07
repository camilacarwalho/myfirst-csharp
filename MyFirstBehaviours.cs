using System;
using UnityEngine;
using System.Collections;


public class MyFirstBehaviourScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            //Ação deve acontecer aqui
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
	
}
