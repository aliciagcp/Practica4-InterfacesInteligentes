using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notifier2 : MonoBehaviour
{
    public delegate void CollectSpheres(int points);
    public event CollectSpheres OnCollectSpheres;
     
    private void OnCollisionEnter(Collision collision)
    {
        if(OnCollectSpheres != null && collision.gameObject.tag == "Grupo2")
        {
            OnCollectSpheres(10);
            Destroy(collision.gameObject);
        }
        else if(OnCollectSpheres != null && collision.gameObject.tag == "Grupo1")
        {
            OnCollectSpheres(5);
            Destroy(collision.gameObject);
        }
    }
}
