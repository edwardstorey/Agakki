using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHitController : MonoBehaviour
{
    private float appearWindow;
    private int hand;

    // Start is called before the first frame update
    void Start()
    {
        appearWindow = GameObject.Find("Hit Boxes").GetComponent<NoteController>().appearWindow;
        transform.parent = GameObject.Find("Hit Boxes").transform;

        if(tag.Equals("Top"))
        {
            transform.localPosition = new Vector3(-0.45f, -0.15f, 2.0f);
        }
        if (tag.Equals("Bottom"))
        {
            transform.localPosition = new Vector3(0.45f, -0.15f, 2.0f);
        }
        if (tag.Equals("Left"))
        {
            transform.localPosition = new Vector3(0.0f, 0.3f, 2.0f);
        }
        if (tag.Equals("Right"))
        {
            transform.localPosition = new Vector3(0.0f, -0.6f, 2.0f);
        }
        transform.Rotate(0.0f, 0.0f, 45.0f);

    }   

    void FixedUpdate()
    {
        transform.localPosition += new Vector3(0.0f, 0.0f, Time.fixedDeltaTime * -2.5f / (appearWindow));
    }
}
