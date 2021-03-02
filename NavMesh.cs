 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    [SerializeField] Transform destination;
    NavMeshAgent boss;
    public GameObject door;
    DoorScript2 script;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        boss=this.GetComponent<NavMeshAgent>();
        script=door.GetComponent<DoorScript2>();
    }

    void Update()
    {
        if(script.startWalkin)
        {
            boss.SetDestination(destination.position);
            if (Time.time > nextFire)
            {
                nextFire=Time.time+fireRate;
                Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
            }
        }
    }
}
