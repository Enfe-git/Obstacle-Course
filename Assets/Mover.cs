using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float playerSpeed= 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update() {
        MovePlayer();
    }

    private void MovePlayer() {
        float xValue = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        transform.Translate(xValue, 0, zValue);
    }

    void PrintInstructions() 
    {
        Debug.Log("Welcome to the game!\nUse W S A D to move.");
    }

}
