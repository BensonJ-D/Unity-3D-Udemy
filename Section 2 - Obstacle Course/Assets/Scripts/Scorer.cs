using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        hits++;
    }
}
