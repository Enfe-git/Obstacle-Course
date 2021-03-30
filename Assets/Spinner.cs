using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotatation = 0f;
    [SerializeField] float yRotatation = 0.1f;
    [SerializeField] float zRotatation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(xRotatation, yRotatation, zRotatation);
    }


}
