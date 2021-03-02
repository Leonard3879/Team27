using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript001 : MonoBehaviour
{
    float rotationOnX;
    float sensitivity=180f;
    public Transform player;
    public GameObject door;
    DoorScript2 script;

    void Start ()
    {
        Cursor.visible=false;
        Cursor.lockState=CursorLockMode.Locked;
        script=door.GetComponent<DoorScript2>();
    }

    void Update()
    {
        if(script.start)
        {

        }
        else
        {
            float mouseY=Input.GetAxis("Mouse Y")*Time.deltaTime*sensitivity;
            float mouseX=Input.GetAxis("Mouse X")*Time.deltaTime*sensitivity;
            rotationOnX-=mouseY;
            rotationOnX=Mathf.Clamp(rotationOnX,-90f,90f);
            transform.localEulerAngles=new Vector3(rotationOnX,0f,0f);

            player.Rotate(Vector3.up*mouseX);
        }
    }
    
}
