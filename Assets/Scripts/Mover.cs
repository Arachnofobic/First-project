
using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed;
    


    void Start()
    {
        PrintInstruction();
    }

    void Update()
    {
        MovePlayer();
        
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        
    }



    void PrintInstruction()
    {
        Debug.Log("Welcome to the game :D ");
        Debug.Log("To move use WSAD or Arrows ");
        Debug.Log("Point of the game is to avoid any collisions ");
        Debug.Log("Press Q to exit a game ");
    }


    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        ;
        transform.Translate(xValue, 0, zValue);
    }


}
