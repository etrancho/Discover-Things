using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public GameObject playerr;
    public Camera cam;
    public GameObject menuPizza;
    public GameObject menuCroissants;
    public GameObject menuBananas;
    public GameObject menuHamburguer;
    public GameObject menuChinese;
    public GameObject menuKM;
    public GameObject menuOil;
    public GameObject pointer;
    public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
    public void moveCam(){
        cam.transform.position = new Vector3(266.3f, 0, 0);
    }
    public void moveCam2(){
        cam.transform.position = new Vector3(0, 0, 0);
    }
    public void closeMenu(){
        menuPizza.SetActive(false);
        menuCroissants.SetActive(false);
        menuBananas.SetActive(false);
        menuHamburguer.SetActive(false);
        menuChinese.SetActive(false);
        menuKM.SetActive(false);
        menuOil.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        pointer.SetActive(true);
    }
}
