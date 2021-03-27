using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float waitTime = 3f;

    // Start is called before the first frame update
    void Start() {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;

    }

    private void enableObstacle() {
        renderer.enabled = true;
        rigidbody.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > waitTime) 
        {
            Debug.Log("Enough time has passed");
            enableObstacle();

        }
    }
}
