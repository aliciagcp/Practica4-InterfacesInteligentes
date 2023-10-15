using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    public delegate void Contact();
    public event Contact OnContact;
     
    private void OnTriggerEnter(Collider other)
    {
        if(OnContact != null && other.gameObject.name == "Cube")
            OnContact();
    }
}
