using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int timesHit = 0;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag != "Hit" && collision.gameObject.tag != "Button") {
            Debug.Log("You've bumped into " + ++timesHit + " thing(s)");
        }
    }
}
