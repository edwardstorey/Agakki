using System;
using System.Collections;
using System.Collections.Generic;
using Valve.VR;
using UnityEngine;

public class React : MonoBehaviour
{
    private int touch;
    private Color defaultColor;
    private NoteController noteController;
    
    // Start is called before the first frame update
    void Start()
    {
        touch = 0;
        defaultColor = gameObject.GetComponent<Renderer>().material.color;
        noteController = GameObject.Find("Hit Boxes").GetComponent<NoteController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (touch > 1)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(39f / 255f, 24.0f / 255f, 98.0f / 255f, 25.0f / 255f);
        }
        else
        {
            if (other.gameObject.name.Equals("Controller (left)"))
            {
                gameObject.GetComponent<Renderer>().material.color = new Color(236.0f / 255f, 109.0f / 255f, 245.0f / 255f, 25.0f / 255f);
            }
            else if (other.gameObject.name.Equals("Controller (right)"))
            {
                gameObject.GetComponent<Renderer>().material.color = new Color(104.0f / 255f, 239.0f / 255f, 241.0f / 255f, 25.0f / 255f);
            }

        }
    }



    void OnTriggerEnter(Collider other)
    {
        touch++;

    }

    void OnTriggerExit(Collider other)
    {
        touch--;

        if (touch < 1)
        {
            gameObject.GetComponent<Renderer>().material.color = defaultColor;
        }
    }

    public int GetTouch()
    {
        return touch;
    }
}
