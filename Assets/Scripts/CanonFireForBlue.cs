using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonFireForBlue : MonoBehaviour
{
    /*public double S;
    public float Vi=0.0f;*/

    void OnMouseDown()
    {
        Fire();
        // if(transform.Rotate(new Vector3(-65.539f, 0f, 0f)))
        //transform.Rotate(new Vector3(53.49f, 0f, 0f));
    }
    void Fire()
    {
        gameObject.transform.position = new Vector3(47, 1, 11);
    }
}
