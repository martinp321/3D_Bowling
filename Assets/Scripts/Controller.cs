using UnityEngine;
using System.Collections;
using System;

public class Controller : MonoBehaviour
{
    public Camera cam;

    private Ball ball;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        ball = FindObjectOfType<Ball>();
        offset = cam.transform.position - ball.transform.position;
    }



    // Update is called once per frame
    void Update()
    {
        cam.transform.position = ball.transform.position + offset;
    }
}
