using UnityEngine;

public class jump : MonoBehaviour
{
    public int power = 50;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       // GetComponent<Rigidbody>().AddForce(Vector3.up * 20, ForceMode.VelocityChange);
    }    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.forward * 20, ForceMode.VelocityChange);
        }
    }
}
