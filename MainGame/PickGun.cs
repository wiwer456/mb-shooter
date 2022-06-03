using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickGun : MonoBehaviour
{
    public GameObject gun; 
    public GameObject pickGun;
    
    public Camera cam;
    int pick = 0;

    public GameObject pickPanel;

    void Start()
    {
        pickPanel.SetActive(false);    
    }

    
    void Update()
    {
        pickPanel.SetActive(false);    
        Debug.DrawRay(cam.transform.position, cam.transform.forward * 100f, Color.green);
        RaycastHit hit;

        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100)){
                if(hit.transform.gameObject.tag=="item2"){
                    pickPanel.SetActive(true);
                        if(Input.GetKeyDown("f")){
                            pickPanel.SetActive(false);  
                            pick = 1;
                            PlayerPrefs.SetInt("IsPicked", pick);
                            PlayerPrefs.Save();
                            gun.SetActive(true);
                            
                            pickGun.SetActive(false);
                            print(PlayerPrefs.GetInt("IsPicked"));
                        }
                }
               
            }    

        
    }
}
