using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    public float move;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            Vector3 open=new Vector3(transform.position.x+move,transform.position.y,transform.position.z);
            while(transform.position!=open)
            transform.position=Vector3.MoveTowards(transform.position, open, speed*Time.deltaTime);
        }
    }
}
