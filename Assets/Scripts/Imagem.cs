using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Imagem : MonoBehaviour
{
    [HideInInspector] public PORTA porta;
    public Image imagem;
    bool iSwitch;
    bool onCollision;

    void Start()
    {
        imagem.enabled = false;
        onCollision = false;
    }

    void Awake()
    {
        porta = GameObject.Find("GameObject").GetComponent<PORTA>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (!porta.trava)
        {
            onCollision = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        onCollision = false;
        imagem.enabled = false;
    }

    private void Update()
    {
        if (onCollision)
        {
            if (Input.GetButtonDown("Fire1") && !iSwitch)
            {
                imagem.enabled = !imagem.enabled;
                iSwitch = true;
                return;
            }

            if (Input.GetButtonDown("Fire1") && iSwitch)
            {
                imagem.enabled = false;
                iSwitch = false;
                return;
            }
        }
    }

    void OnGUI()
    {
        if (onCollision && imagem.enabled == false)
        {
            GUI.Box(new Rect(280, 180, 200, 45), "Aperte 'E' para ler o papel ");
        }
    }
}