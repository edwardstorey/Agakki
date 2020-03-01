using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitNode
{
    public float time;
    public int left;
    public int right;
    public int both;

    public HitNode(float time, int left, int right, int both)
    {
        this.time = time;
        this.left = left;
        this.right = right;
        this.both = both;
    }
}
