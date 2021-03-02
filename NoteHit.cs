using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHit : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    public KeyCode otherKey;
    public int animationNumber;
    public int turnOnForFrank;
    public int turnOnForBoss;
    public GameObject frankMesh;
    public GameObject bossMesh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress)||Input.GetKeyDown(otherKey))
        {
            if(canBePressed)
            {
                //turnOnForFrank=animationNumber;
                gameObject.SetActive(false);

                DDRManager.instance.HitNote();
            }
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Is colliding");
        if(other.tag=="Activator")
        {
            //turnOnForBoss=animationNumber;
            canBePressed=true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag=="Activator")
        {
            canBePressed=false;
            DDRManager.instance.MissedNote();
        }
    }
}
