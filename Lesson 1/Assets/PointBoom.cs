using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointBoom : MonoBehaviour
{
    public float radius = 5.0f;
    public float force = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 boomPosition = transform.position;
        Collider[] colliders = Physics.OverlapSphere(boomPosition, radius);

        foreach (Collider hit in colliders) {
            // Rigidbody rb = hit.GetComponent<Rigidbody>();
            Rigidbody rb = GetComponent<Rigidbody>();

            if (rb != null) {
                rb.AddExplosionForce(force, boomPosition, radius, 3.0f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
