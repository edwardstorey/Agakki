using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public float wingSpan;
    private GameObject controller1;
    private GameObject controller2;
    
    // Start is called before the first frame update
    void Start()
    {
        controller1 = GameObject.Find("Controller (left)");
        controller2 = GameObject.Find("Controller (right)");
    }

    // Update is called once per frame
    void Update()
    {
        if (wingSpan == 0)
        {
            wingSpan = controller2.transform.position.x - controller1.transform.position.x;
            transform.localScale = new Vector3(wingSpan, wingSpan, wingSpan);
            Debug.Log(wingSpan);
        }
    }
}
