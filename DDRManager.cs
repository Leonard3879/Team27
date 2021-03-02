using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDRManager : MonoBehaviour
{
    public AudioSource DDRSong;
    public bool startPlaying;
    public ArrowController AC;
    public static DDRManager instance;
    public GameObject door;
    DoorScript2 script;
    public GameObject[] health;
    int count;
    
    // Start is called before the first frame update
    void Start()
    {
        
        instance=this; 
        script=door.GetComponent<DoorScript2>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying)
        {
            //set up trigger for when to start DDR
            if(script.start) 
            {
                startPlaying=true;
                AC.hasStarted=true;
                DDRSong.Play();

            }
        }
        
    }

    public void HitNote()
    {
        
    }

    public void MissedNote()
    {
        
    }
}
