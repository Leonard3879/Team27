using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController001 : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    public GameObject door;
    DoorScript2 script;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public KeyCode fire;

    private float nextFire;

    void Start()
    {
        script=door.GetComponent<DoorScript2>();
    }

    private void Update()
    {
        if(script.start)
        {

        }
        else
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            transform.Translate(new Vector3(horizontal, 0, vertical) * (speed * Time.deltaTime));
                //Attack script for attack
            if (Input.GetKeyDown(fire) && Time.time > nextFire)
            {
                nextFire=Time.time+fireRate;
                Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
            }
        }
        
    }
}
