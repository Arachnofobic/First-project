
using System;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You've bumped into a thing " + hits + " times");
        }
    }


}
