using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private void Start()
    {
        PrintInstrutcion();
    }

    private void Update()
    {
        movePlayer();
    }

    void PrintInstrutcion()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("String One");
        Debug.Log("String Two");
    }

    void movePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
