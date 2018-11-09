using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacoes : MonoBehaviour
{
    private Animator controladoorQuadro;
    public bool quadro;

    void Start()
    {
        controladoorQuadro = GetComponent<Animator>();
        quadro = true;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            controladoorQuadro.SetInteger("condicao", 0);
            quadro = false;
        }

        if (Input.GetButtonDown("Fire3"))
        {
            controladoorQuadro.SetInteger("condicao", 1);
            quadro = false;
        }
    }
}