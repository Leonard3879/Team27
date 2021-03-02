using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Text IM;
    public Sprite def;
    public Sprite pressed;
    public KeyCode keyToPress;
    public KeyCode otherKeyPress;
    public byte r,b,g;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            IM.color = new Color32(r,b,g,255);
        }
        if(Input.GetKeyUp(keyToPress))
        {
            IM.color = new Color32(50,50,50,255);
        }
        
    }
}
