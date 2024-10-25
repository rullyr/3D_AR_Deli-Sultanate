using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject HomeMenu;
    public GameObject MainMenu;
    public GameObject InfoMenu;

    void Start() {
        HomeMenu.SetActive(true);
        MainMenu.SetActive(false);
        InfoMenu.SetActive(false);
    }

    public void MulaiClicked() {
        HomeMenu.SetActive(false);
        MainMenu.SetActive(true);
        InfoMenu.SetActive(false);
    }

    public void InfoClicked() {
        HomeMenu.SetActive(false);
        MainMenu.SetActive(false);
        InfoMenu.SetActive(true);
    }

    public void KembaliClicked(){
        HomeMenu.SetActive(true);
        MainMenu.SetActive(false);
        InfoMenu.SetActive(false);
    }

    public void ModelClicked() {
        Application.LoadLevel("Model");
    }

    public void Keluar_Clicked(){
        Application.Quit();
    }
}
