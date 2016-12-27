using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    private Vector3 velocity;

    private Rigidbody body;
    private Vector3 offset;

    private Vector3 dragStart, dragEnd;
    private float startTime, endTime;

    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody>();
        velocity = new Vector3(0f, 0f, -250f);
        Launch(velocity);

    }

    private void Launch(Vector3 velocity)
    {
        body.useGravity = true;
        body.velocity += velocity;
    }

    public void DragStart()
    {
        //distance/time = speed

        dragStart = Input.mousePosition;
        startTime = Time.time;

    }

    public void DragEnd()
    {

        dragEnd = Input.mousePosition;
        endTime = Time.time;

        float dragDuration = endTime - startTime;
        float launchSpeedX = Mathf.Clamp((dragEnd.x - dragStart.x) / dragDuration, -30, 30);
        float launchSpeedZ = (dragEnd.y - dragStart.y) / dragDuration;

        velocity = new Vector3(-launchSpeedX, 0f, -launchSpeedZ);
        Launch(velocity);
    }

    public void moveLeft()
    {
        transform.position += Vector3.right * 10f;

    }

    public void moveRight()
    {
        transform.position += Vector3.left * 10f;

    }

}
