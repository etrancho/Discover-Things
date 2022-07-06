using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class PointerControl : MonoBehaviour
{
    public Camera PlayerCamera;
    public float RayLength;
    string currentObject;

    void Start()
    {
        currentObject = "";
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // if (Input.GetMouseButtonDown(0) && !Menu.InSettings && !Menu2.InLogin && !Menu3.InRegister && !Chat.InChat)
        // {
        //     CurrentObjectHandler();
        //     Cursor.lockState = CursorLockMode.Locked;
        // } else if (Input.GetMouseButtonDown(0)){
        //     
        // }
        if (Input.GetMouseButtonDown(0))
        {
            CurrentObjectHandler();
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    void CurrentObjectHandler()
    {
        RaycastHit hit;
        if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out hit, RayLength))
        {
            currentObject = hit.transform.name;
            Debug.Log(currentObject);
        }
        

        switch (currentObject)
        {
            case "buttonScene2":
                hit.transform.gameObject.GetComponent<Button>().onClick.Invoke();
                currentObject = "buttonScene2Exit";
                break;
            case "buttonMenu":
                hit.transform.gameObject.GetComponent<Button>().onClick.Invoke();
                currentObject = "buttonMenuExit";
                Cursor.lockState = CursorLockMode.None;
                break;
            
        }
        
    }
}
