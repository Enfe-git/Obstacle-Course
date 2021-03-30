using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocker : MonoBehaviour
{
    GameObject blocker1;
    GameObject blocker2;
    GameObject blocker3;

    private void Start() {
        blocker1 = GameObject.FindGameObjectWithTag("Blocker1");
        blocker2 = GameObject.FindGameObjectWithTag("Blocker2");
        blocker3 = GameObject.FindGameObjectWithTag("Blocker3");
    }

    private void OnCollisionEnter(Collision collision) {
        void removeBlocker(GameObject blocker) {
            blocker.GetComponent<MeshRenderer>().enabled = false;
            blocker.GetComponent<BoxCollider>().enabled = false;

        }
        switch (gameObject.name) 
        {
            case "Button1":
                removeBlocker(blocker1);
                break;
            case "Button2":
                removeBlocker(blocker2);
                break;
            case "Button3":
                removeBlocker(blocker3);
                break;
            default:
                break;
        } 

    }
}
