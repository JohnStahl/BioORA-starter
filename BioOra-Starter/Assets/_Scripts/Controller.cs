﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour    
{
    GameObject sphere1;
    GameObject sphere2;
    GameObject cylinder1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*
             * Note that the invisible objects in the scene were used as a visual reference to hardcode positioning
             * and they are not the same objects being generated by the code below
             * */
            sphere1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere1.transform.position = new Vector3(-0.78f, 0f, -7.547f);
            sphere2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere2.transform.position = new Vector3(0.95f, 1.31f, -7.547f);
            cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cylinder1.transform.position = new Vector3(.1f, .7f, -7.547f);
            cylinder1.transform.localScale = new Vector3(.25f, 1f, .25f);
            cylinder1.transform.Rotate(0, 0, -52.14f);
            var cube1Renderer = sphere1.GetComponent<Renderer>();
            cube1Renderer.material.SetColor("_Color", Color.red);
            var cube2Renderer = sphere2.GetComponent<Renderer>();
            cube2Renderer.material.SetColor("_Color", Color.red);
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
