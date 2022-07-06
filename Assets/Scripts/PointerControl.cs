using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class PointerControl : MonoBehaviour
{
    public Camera PlayerCamera;
    public float RayLength;
    string currentObject;
    //bedrolls
    public GameObject roll1;
    public GameObject bedroll1;
    public GameObject roll2;
    public GameObject bedroll2;
    public GameObject fire;
    //boxes
    public GameObject box;
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject boxOpen;
    public GameObject boxOpen1;
    public GameObject boxOpen2;
    public GameObject boxOpen3;
    //lights
    public GameObject light;
    public GameObject lightD;
    public GameObject light2;
    public GameObject light2D;
    public GameObject light3;
    public GameObject light3D;
    public GameObject light4;
    public GameObject light4D;
    public GameObject light5;
    public GameObject light5D;
    public GameObject light6;
    public GameObject light6D;
    public GameObject light7;
    public GameObject light7D;

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
            //buttons
            case "buttonScene2":
                hit.transform.gameObject.GetComponent<Button>().onClick.Invoke();
                currentObject = "buttonScene2Exit";
                break;
            case "buttonMenu":
                hit.transform.gameObject.GetComponent<Button>().onClick.Invoke();
                currentObject = "buttonMenuExit";
                break;
            case "buttonCity":
                hit.transform.gameObject.GetComponent<Button>().onClick.Invoke();
                currentObject = "buttonCityExit";
                break;
            //bedrolls
            case "roll1":
                roll1.SetActive(false);
                bedroll1.SetActive(true);
                currentObject = "roll1Exit";
                break;
            case "roll2":
                roll2.SetActive(false);
                bedroll2.SetActive(true);
                currentObject = "roll2Exit";
                break;
            case "bedroll1":
                bedroll1.SetActive(false);
                roll1.SetActive(true);
                currentObject = "bedroll1Exit";
                break;
            case "bedroll2":
                bedroll2.SetActive(false);
                roll2.SetActive(true);
                currentObject = "bedroll2Exit";
                break;
            //fire
            case "rocksCampfire":
                fire.SetActive(true);
                currentObject = "rocksCampfireExit";
                break;
            //boxes
            case "box":
                box.SetActive(false);
                boxOpen.SetActive(true);
                currentObject = "boxOpenExit";
                break;
            case "box1":
                box1.SetActive(false);
                boxOpen1.SetActive(true);
                currentObject = "boxOpen1Exit";
                break;
            case "box2":
                box2.SetActive(false);
                boxOpen2.SetActive(true);
                currentObject = "boxOpen2Exit";
                break;
            case "box3":
                box3.SetActive(false);
                boxOpen3.SetActive(true);
                currentObject = "boxOpen3Exit";
                break;
            //lights
            case "lampFloorLRLIGHT":
                light.SetActive(false);
                lightD.SetActive(true);
                currentObject = "lampFloorLRExit";
                break;
            case "lampFloorLRDARK":
                light.SetActive(true);
                lightD.SetActive(false);
                currentObject = "lampFloorLRExit";
                break;
            case "lampFloorLR2LIGHT":
                light2.SetActive(false);
                light2D.SetActive(true);
                currentObject = "lampFloorLR2Exit";
                break;
            case "lampFloorLR2DARK":
                light2.SetActive(true);
                light2D.SetActive(false);
                currentObject = "lampFloorLRExit";
                break;
            case "lampTableLIGHT":
                light3.SetActive(false);
                light3D.SetActive(true);
                currentObject = "lampTableExit";
                break;
            case "lampTableDARK":
                light3.SetActive(true);
                light3D.SetActive(false);
                currentObject = "lampTableExit";
                break;
            case "lampFloorOLIGHT":
                light4.SetActive(false);
                light4D.SetActive(true);
                currentObject = "lampFloorOExit";
                break;
            case "lampFloorODARK":
                light4.SetActive(true);
                light4D.SetActive(false);
                currentObject = "lampFloorOExit";
                break;
            case "lampWallLRLIGHT":
                light5.SetActive(false);
                light5D.SetActive(true);
                currentObject = "lampFloorOExit";
                break;
            case "lampWallLRDARK":
                light5.SetActive(true);
                light5D.SetActive(false);
                currentObject = "lampFloorOExit";
                break;
            case "lightpostLIGHT":
                light6.SetActive(false);
                light6D.SetActive(true);
                currentObject = "lampFloorOExit";
                break;
            case "lightpostDARK":
                light6.SetActive(true);
                light6D.SetActive(false);
                currentObject = "lampFloorOExit";
                break;
            case "lampWallBLIGHT":
                light7.SetActive(false);
                light7D.SetActive(true);
                currentObject = "lampFloorOExit";
                break;
            case "lampWallBDARK":
                light7.SetActive(true);
                light7D.SetActive(false);
                currentObject = "lampFloorOExit";
                break;
            
        }
        
    }
}
