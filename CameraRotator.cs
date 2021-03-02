﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public static float speed=0.11f;
    public static float width=2.5f;
    public float offset;
    float timeCounter;
    float x, z;
    bool rotate;
    // Start is called before the first frame update
    void Start()
    {
        timeCounter=0;
    }

    // Update is called once per frame
    void Update()
    {
            timeCounter+=(Time.deltaTime)*speed;
            x= Mathf.Cos(timeCounter)*width;
            z= Mathf.Sin(timeCounter)*width;
            Vector3 position= new Vector3(x,2.5f,z);
            transform.LookAt(position+transform.position);
            Vector3 tilt=transform.rotation.eulerAngles;
            tilt.y=180;
            tilt.x=65;
            Vector3 angle = this.transform.rotation.eulerAngles;
            transform.rotation=Quaternion.Euler(tilt+angle);
            Vector3 buffer=new Vector3(0f,0f,offset);
            transform.position = position+buffer;
    }
}
