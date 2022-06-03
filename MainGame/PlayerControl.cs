using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Transform Pler;
    CharacterController cntrl;
    public float speed = 12f;

    void Start()
    {
        Pler = GetComponent<Transform>();
        cntrl = GetComponent<CharacterController>();   
    }

    
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        cntrl.Move(Pler.forward * vertical * speed * Time.deltaTime);
        cntrl.Move(Pler.right * horizontal * speed * Time.deltaTime);
    }
}
