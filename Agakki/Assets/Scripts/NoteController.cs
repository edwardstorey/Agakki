using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class NoteController : MonoBehaviour
{
    public float appearWindow;
    public int score;
    private GameObject[] gameObjects;
    private AudioSource audioSource;
    private Queue<HitNode> hitQueue;

    void Start()
    {
        gameObjects = new GameObject[] { GameObject.Find("Top Left Hit"), GameObject.Find("Top Right Hit"), GameObject.Find("Bottom Left Hit"), GameObject.Find("Bottom Right Hit"), GameObject.Find("Top Hit"), GameObject.Find("Right Hit"), GameObject.Find("Bottom Hit"), GameObject.Find("Left Hit")};
        audioSource = GameObject.Find("Camera").GetComponent<AudioSource>();
        hitQueue = new Queue<HitNode>();

        PopulateQueue();
    }

    void FixedUpdate()
    {
        if (hitQueue.Peek().time - appearWindow <= audioSource.time)
        {
            if (hitQueue.Peek().left > -1)
            {
                Instantiate(gameObjects[hitQueue.Peek().left]);

                if (gameObjects[hitQueue.Peek().left].GetComponent<TriHitController>() != null)
                {
                    gameObjects[hitQueue.Peek().left].GetComponent<TriHitController>().enabled = true;
                }
                else
                {
                    gameObjects[hitQueue.Peek().left].GetComponent<BlockHitController>().enabled = true;
                }
            }
            if (hitQueue.Peek().right > -1)
            {
                Instantiate(gameObjects[hitQueue.Peek().right]);

                if (gameObjects[hitQueue.Peek().right].GetComponent<TriHitController>() != null)
                {
                    gameObjects[hitQueue.Peek().right].GetComponent<TriHitController>().enabled = true;
                }
                else
                {
                    gameObjects[hitQueue.Peek().right].GetComponent<BlockHitController>().enabled = true;
                }
            }
            if (hitQueue.Peek().both > -1)
            {
                Instantiate(gameObjects[hitQueue.Peek().both]);

                Debug.Log(hitQueue.Peek().both);

                if (gameObjects[hitQueue.Peek().both].GetComponent<TriHitController>() != null)
                {
                    gameObjects[hitQueue.Peek().both].GetComponent<TriHitController>().enabled = true;
                }
                else
                {
                    gameObjects[hitQueue.Peek().both].GetComponent<BlockHitController>().enabled = true;
                }
            }

            hitQueue.Dequeue();
        }
    }

    void PopulateQueue()
    {
        StreamReader reader = File.OpenText("Assets/Beatmaps/YMCA-Beatmap.csv");
        string current = reader.ReadLine();
        current = reader.ReadLine();
        while (current != null)
        {
            string[] param = current.Split(',');

            hitQueue.Enqueue(new HitNode(Convert.ToSingle(param[0]), Convert.ToInt32(param[1]), Convert.ToInt32(param[2]), Convert.ToInt32(param[3])));
            current = reader.ReadLine();
        }
    }
}
