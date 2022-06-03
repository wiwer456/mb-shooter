using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Gun1 : MonoBehaviour
{
    Animator anim;
    public Camera cam;
    int cartridges = 1;

    [SerializeField] TextMeshProUGUI Ammo;
    public GameObject AmmoC;
    
    [SerializeField] TextMeshProUGUI [] Targets;
    public GameObject targetpanel;
    int targets2 = 0;
    int targets1 = 13;

    public GameObject asd;
    void Start()
    {
        anim = GetComponent<Animator>();
        targetpanel.SetActive(true);
    }

    
    void Update()
    {
        Debug.DrawRay(cam.transform.position, cam.transform.forward * 100f, Color.green);
        RaycastHit hit;

        
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100)){
                if(hit.transform.gameObject.tag=="item2"){
                    if(Input.GetKeyDown("f")){
                        print("asd");
                    }
                }
               
            }    

        

            
        
            if(Input.GetKeyDown("1")){
                anim.SetBool("Equip", true);
                anim.SetBool("UnEquip", false);
                AmmoC.SetActive(true);
                asd.SetActive(true);
                print("взял");
            }
            if(Input.GetKeyDown("l")){
                anim.SetBool("UnEquip", true);
                anim.SetBool("Equip", false);
                AmmoC.SetActive(false);
            }
            if(Input.GetButtonDown("Fire1") && cartridges == 1){
                    anim.SetBool("Shoot1", true);
                    cartridges = 0;
                    string Ammos = cartridges +"";
                    Ammo.text = Ammos +"/1";
                    if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100)){
                
                        if(hit.transform.gameObject.tag == "bad"){
                            Destroy(hit.transform.gameObject);
                            targets2 += 1;
                            targets1 -= 1;
                            string trg12 = targets2 +"";
                            Targets[0].text = "Осталось:" + targets1+"";
                            Targets[1].text = trg12 + "/13";
                            if(targets2 == 13){
                                SceneManager.LoadScene("ChoosingLevel");
                            }
                        }
                    }
            }
                if(Input.GetButtonUp("Fire1")){
                    anim.SetBool("Shoot1", false);
                }
            if(Input.GetKeyDown("r") && cartridges == 0){
                anim.SetBool("Reload", true);
                cartridges = 1;
                string Ammos = cartridges +"";
                Ammo.text = Ammos +"/1";
            }
                if(Input.GetKeyUp("r")){
                    anim.SetBool("Reload", false);
                }
        
        
    }

    
}
