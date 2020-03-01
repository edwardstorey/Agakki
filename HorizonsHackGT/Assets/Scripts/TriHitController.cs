using System;
using System.Collections;
using System.Collections.Generic;
using Valve.VR;
using UnityEngine;

public class TriHitController : MonoBehaviour
{
    private float appearWindow;

    // Start is called before the first frame update
    void Start()
    {
        appearWindow = GameObject.Find("Hit Boxes").GetComponent<NoteController>().appearWindow;
        transform.parent = GameObject.Find("Hit Boxes").transform;
        transform.localPosition = new Vector3(0.0f, -0.14f, 0.1f);
    }

    void FixedUpdate()
    {
        if (tag.Equals("Top Right"))
        {
            transform.localPosition += new Vector3(Time.fixedDeltaTime * 0.15f / appearWindow, Time.fixedDeltaTime * 0.14f / appearWindow, 0.0f);
        }
        if (tag.Equals("Top Left"))
        {
            transform.localPosition += new Vector3(Time.fixedDeltaTime * (-0.15f) / appearWindow, Time.fixedDeltaTime * 0.14f / appearWindow, 0.0f);
        }
        if (tag.Equals("Bottom Left"))
        {
            transform.localPosition += new Vector3(Time.fixedDeltaTime * (-0.15f) / appearWindow, Time.fixedDeltaTime * (-0.14f) / appearWindow, 0.0f);
        }
        if (tag.Equals("Bottom Right"))
        {
            transform.localPosition += new Vector3(Time.fixedDeltaTime * 0.15f / appearWindow, Time.fixedDeltaTime * (-0.14f) / appearWindow, 0.0f);
        }
    }
}
