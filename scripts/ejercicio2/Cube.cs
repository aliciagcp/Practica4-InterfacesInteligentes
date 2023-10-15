using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public delegate void ContactGroup1();
    public event ContactGroup1 OnContactGroup1;
    public delegate void ContactOtherGroup();
    public event ContactOtherGroup OnContactOtherGroup;
     
    private void OnCollisionEnter(Collision collision)
    {
        if(OnContactOtherGroup != null && collision.gameObject.tag != "Grupo1")
        {
            OnContactOtherGroup();
        }
        else if(OnContactOtherGroup != null && collision.gameObject.tag == "Grupo1")
        {
            OnContactGroup1();
        }
    }
}
