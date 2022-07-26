using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class PointerControl : MonoBehaviour
{
    public Camera PlayerCamera;
    public float RayLength;
    string currentObject;
    public GameObject pointer;

    //bedrolls and fire
    public GameObject roll1;
    public GameObject bedroll1;
    public GameObject roll2;
    public GameObject bedroll2;
    public GameObject campfire;
    public GameObject campfireNO;
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
    public GameObject light1;
    public GameObject light1D;
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
    public GameObject light8;
    public GameObject light8D;
    public GameObject light9;
    public GameObject light9D;

    //menus
    public GameObject menuPizza;
    public GameObject menuCroissants;
    public GameObject menuBananas;
    public GameObject menuHamburguer;
    public GameObject menuChinese;
    public GameObject menuKM;
    public GameObject menuOil;

    //audio
    public AudioSource fire;
    public AudioSource switchs;

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
            case "campfire":
                campfire.SetActive(false);
                campfireNO.SetActive(true);
                fire.Play();
                currentObject = "rocksCampfireExit";
                break;
            case "campfireNO":
                campfireNO.SetActive(false);
                campfire.SetActive(true);
                fire.Stop();
                currentObject = "rocksCampfireExit";
                break;
            //boxes
            case "box":
                box.SetActive(false);
                boxOpen.SetActive(true);
                currentObject = "boxOpenExit";
                break;
            case "boxOpen":
                boxOpen.SetActive(false);
                box.SetActive(true);
                currentObject = "boxOpenExit";
                break;
            case "box1":
                box1.SetActive(false);
                boxOpen1.SetActive(true);
                currentObject = "boxOpen1Exit";
                break;
            case "boxOpen1":
                boxOpen1.SetActive(false);
                box1.SetActive(true);
                currentObject = "boxOpenExit";
                break;
            case "box2":
                box2.SetActive(false);
                boxOpen2.SetActive(true);
                currentObject = "boxOpen2Exit";
                break;
            case "boxOpen2":
                boxOpen2.SetActive(false);
                box2.SetActive(true);
                currentObject = "boxOpenExit";
                break;
            case "box3":
                box3.SetActive(false);
                boxOpen3.SetActive(true);
                currentObject = "boxOpen3Exit";
                break;
            case "boxOpen3":
                boxOpen3.SetActive(false);
                box3.SetActive(true);
                currentObject = "boxOpenExit";
                break;
            //lights
            case "lampFloorLRLIGHT":
                light1.SetActive(false);
                light1D.SetActive(true);
                switchs.Play();
                currentObject = "lampFloorLRExit";
                break;
            case "lampFloorLRDARK":
                light1.SetActive(true);
                light1D.SetActive(false);
                switchs.Play();
                currentObject = "lampFloorLRExit";
                break;
            case "lampFloorLR2LIGHT":
                light2.SetActive(false);
                light2D.SetActive(true);
                switchs.Play();
                currentObject = "lampFloorLR2Exit";
                break;
            case "lampFloorLR2DARK":
                light2.SetActive(true);
                light2D.SetActive(false);
                switchs.Play();
                currentObject = "lampFloorLRExit";
                break;
            case "lampTableLIGHT":
                light3.SetActive(false);
                light3D.SetActive(true);
                switchs.Play();
                currentObject = "lampTableExit";
                break;
            case "lampTableDARK":
                light3.SetActive(true);
                light3D.SetActive(false);
                switchs.Play();
                currentObject = "lampTableExit";
                break;
            case "lampFloorOLIGHT":
                light4.SetActive(false);
                light4D.SetActive(true);
                switchs.Play();
                currentObject = "lampFloorOExit";
                break;
            case "lampFloorODARK":
                light4.SetActive(true);
                light4D.SetActive(false);
                switchs.Play();
                currentObject = "lampFloorOExit";
                break;
            case "lampWallLRLIGHT":
                light5.SetActive(false);
                light5D.SetActive(true);
                switchs.Play();
                currentObject = "lampFloorOExit";
                break;
            case "lampWallLRDARK":
                light5.SetActive(true);
                light5D.SetActive(false);
                switchs.Play();
                currentObject = "lampFloorOExit";
                break;
            case "lightpostLIGHT":
                light6.SetActive(false);
                light6D.SetActive(true);
                switchs.Play();
                currentObject = "lampFloorOExit";
                break;
            case "lightpostDARK":
                light6.SetActive(true);
                light6D.SetActive(false);
                switchs.Play();
                currentObject = "lampFloorOExit";
                break;
            case "lampWallBLIGHT":
                light7.SetActive(false);
                light7D.SetActive(true);
                switchs.Play();
                currentObject = "lampFloorOExit";
                break;
            case "lampWallBDARK":
                light7.SetActive(true);
                light7D.SetActive(false);
                switchs.Play();
                currentObject = "lampFloorOExit";
                break;
            case "lampFloorKLIGHT":
                light8.SetActive(false);
                light8D.SetActive(true);
                switchs.Play();
                currentObject = "lampFloorKExit";
                break;
            case "lampFloorKDARK":
                light8.SetActive(true);
                light8D.SetActive(false);
                switchs.Play();
                currentObject = "lampFloorKExit";
                break;
            case "lampWallKLIGHT":
                light9.SetActive(false);
                light9D.SetActive(true);
                switchs.Play();
                currentObject = "lampFloorKExit";
                break;
            case "lampWallKDARK":
                light9.SetActive(true);
                light9D.SetActive(false);
                switchs.Play();
                currentObject = "lampFloorKExit";
                break;
            //food
            case "infoPizza":
                menuPizza.SetActive(true);
                pointer.SetActive(false);
                Time.timeScale = 0f;
                currentObject = "PIZZAExit";
                break;
            case "infoCroissant":
                menuCroissants.SetActive(true);
                pointer.SetActive(false);
                Time.timeScale = 0f;
                currentObject = "CROISSANT1Exit";
                break;
            case "infoBananas":
                menuBananas.SetActive(true);
                pointer.SetActive(false);
                Time.timeScale = 0f;
                currentObject = "BANANA1Exit";
                break;
            case "infoBurguer1" or "infoBurguer2":
                menuHamburguer.SetActive(true);
                pointer.SetActive(false);
                Time.timeScale = 0f;
                currentObject = "BURGUERKINGExit";
                break;
            case "infoChinese1" or "infoChinese2":
                menuChinese.SetActive(true);
                pointer.SetActive(false);
                Time.timeScale = 0f;
                currentObject = "CHINESE1Exit";
                break;
            case "infoKetchup" or "infoMustard":
                menuKM.SetActive(true);
                pointer.SetActive(false);
                Time.timeScale = 0f;
                currentObject = "KETCHUPExit";
                break;
            case "infoOil":
                menuOil.SetActive(true);
                pointer.SetActive(false);
                Time.timeScale = 0f;
                currentObject = "OILExit";
                break;
        }
        
    }
}
