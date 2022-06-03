using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_hat : MonoBehaviour
{
    Rigidbody rig;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        
    }

    void OnMouseDown(){
        rig.AddForce(0, 600, 600);
    }
}
