using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        //sphere.transform.position = new Vector3(0, 1.0f, 0);
        //transform.position = new Vector3(0, 1.0f, 0);
        //rend = GetComponent<Renderer>();
        //sphere.gameObject.GetComponent<Renderer>().material.color = Color.red;
        sphere.gameObject.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Colliding with: " + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with: " + other.gameObject.name);
    }
}
