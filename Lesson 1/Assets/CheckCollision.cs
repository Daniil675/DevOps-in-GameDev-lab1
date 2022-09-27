using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        Debug.Log("Enter collision with" + other.gameObject.name);
        // other.GetComponent<Renderer>().material.color = Color.red;
        if (other.gameObject.name == "Cube") {
            other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        }
    }

    private void OnCollisionExit(Collision other) {
        Debug.Log("Exit collision with"+other.gameObject.name);
        if (other.gameObject.name == "Cube") {
            other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
    }
}
