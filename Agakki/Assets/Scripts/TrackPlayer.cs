using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
    public float interfaceOffset;
    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Camera");
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + 1);
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, player.transform.position.z + interfaceOffset);
    }
}
