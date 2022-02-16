using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class InputManager : MonoBehaviour
{
    public Gun gun;

    public bool debug = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mouse = Mouse.current;
        if(mouse == null) return;

        

        if(mouse.leftButton.wasPressedThisFrame)
        {
            //if (debug) Debug.Log("Left Mouse Button was pressed this frame");
           
            if(gun != null)
            {
                gun.Fire();
            }
        }
        var keyboard = Keyboard.current;
        if(keyboard.rKey.wasPressedThisFrame){
            if (debug) Debug.Log("Reloaded");

            if(gun != null)
            {
                gun.Reload();
            }     
               }
    }
}
