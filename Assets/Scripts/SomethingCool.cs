using UnityEngine;

public class SomethingCool : MonoBehaviour
{
    bool transform_finished = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (transform_finished == false)
            {
                transform.localScale = transform.localScale * 3f;
                transform_finished = true;
                Debug.Log(name + " is knocked over");
            }
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Player"));
        //{
        //    Time.timeScale = 0.2f;
        //    Time.fixedDeltaTime *= Time.timeScale;
        //    Debug.Log(collision.collider.name);
        //}
        // Debug.Log("Colliding with Player");

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Stopped colliding with Player");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
//Time.timeScale = 0.2f;
//Time.fixedDeltaTime *= Time.timeScale;
//Debug.Log(collision.collider.name);