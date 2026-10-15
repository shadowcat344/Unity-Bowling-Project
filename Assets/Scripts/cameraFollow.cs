using System.Collections;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class cameraFollow : MonoBehaviour
{
    public GameObject ball;
    //public Transform ballTransform;
    public Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    public Transform target;
    void Update()
    {
        transform.position = ball.transform.position + offset;
        transform.LookAt(target);
    }
}
///THE LOOKAT FUNCTION
public class ExampleClass : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        // Rotate the camera every frame so it keeps looking at the target
        //transform.LookAt(target); 
    }
}
