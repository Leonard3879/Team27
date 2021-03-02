using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript2 : MonoBehaviour
{
    public bool start;
    public bool startWalkin;
    float count=0.0f;
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public GameObject health;
    public GameObject textH;
    public GameObject L;
    public GameObject I;
    public GameObject F;
    public GameObject T;
    public GameObject arrows;
    public AudioSource background;
    public GameObject bossCollider;
    // Start is called before the first frame update
    void Start()
    {
        health.SetActive(false);
        textH.SetActive(false);
        L.SetActive(false);
        I.SetActive(false);
        F.SetActive(false);
        T.SetActive(false);
        arrows.SetActive(false);
        cam1.enabled=true;
        cam2.enabled=false;
        cam3.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(start)
        {
            if(count==0.0f)
            {
                cam1.enabled=false;
                cam3.enabled=true;
                //health.SetActive(true);
                //textH.SetActive(true);
                L.SetActive(true);
                I.SetActive(true);
                F.SetActive(true);
                T.SetActive(true);
                arrows.SetActive(true);
                background.Stop();
            }
            if(count>=10.0f&&count<=20.0f)
            {
                cam3.enabled=false;
                cam2.enabled=true;
            }
            if(count>20.0f&&count<=30.0f)
            {
                cam3.enabled=true;
                cam2.enabled=false;
            }
            if(count>30.0f)
            {
                cam3.enabled=false;
                cam2.enabled=true;
            }
            count+=Time.deltaTime;
            if(count>35.0f)
            {
                start=false;
                cam1.enabled=true;
                cam2.enabled=false;
                cam3.enabled=false;
                //health.SetActive(false);
                //textH.SetActive(false);
                L.SetActive(false);
                I.SetActive(false);
                F.SetActive(false);
                T.SetActive(false);
                arrows.SetActive(false);
                background.Play();
                startWalkin=true;
                bossCollider.SetActive(true);
            }
               
        }
    }

    void OnTriggerEnter(Collider player)
    {
        if(player.tag=="Player")
        {
            if(!start&&count==0.0f)
            {
                start=true;
            }
        }
        
    }

}
