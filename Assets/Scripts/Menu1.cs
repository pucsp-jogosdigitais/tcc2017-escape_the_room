using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;


public class Menu1 : MonoBehaviour
{ 
    public FirstPersonController controlador;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void Jogar()
    {
        SceneManager.LoadScene("Load");
    }

    public void VoltarMenuPrincipal()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Voltar()
    {
        Time.timeScale = 1;
        controlador.isPaused = false;
        foreach (GameObject button in controlador.pauseMenuButtons)
        {
            button.SetActive(false);
        }
    }

    public void Sair()
    {
        Application.Quit();
    }
}
