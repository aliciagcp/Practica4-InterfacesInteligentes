using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notifier2 : MonoBehaviour
{
    public delegate void CollectSpheres(int points);
    public event CollectSpheres OnCollectSpheres;

    public delegate void ContactCapsule();
    public event ContactCapsule OnContactCapsule;

    public float jumpForce = 10f;
     
    private void OnCollisionEnter(Collision collision)
    {
        if(OnCollectSpheres != null && collision.gameObject.tag == "Grupo2")
        {
            Material sphereMaterial = collision.gameObject.GetComponent<Renderer>().material;
            GetComponent<Renderer>().material = sphereMaterial;
            OnCollectSpheres(10);
            Destroy(collision.gameObject);
        }
        else if(OnCollectSpheres != null && collision.gameObject.tag == "Grupo1")
        {
            Material sphereMaterial = collision.gameObject.GetComponent<Renderer>().material;
            GetComponent<Renderer>().material = sphereMaterial;
            OnCollectSpheres(5);
            Destroy(collision.gameObject);
        }
        else if(OnCollectSpheres != null && collision.gameObject.tag == "Capsule")
        {
            OnCollectSpheres(-3);
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
