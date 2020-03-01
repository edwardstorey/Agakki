using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
    public float interfaceOffset;
    private GameObject player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Camera");
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, player.transform.position.z + interfaceOffset);
    }
}
