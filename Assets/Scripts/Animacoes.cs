﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacoes : MonoBehaviour {

    private Animator controladoorQuadro;

	// Use this for initialization
	void Start () {
        controladoorQuadro = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire2"))
        {
            controladoorQuadro.SetInteger("condicao", 0);
        }
		if (Input.GetButtonDown("Fire3"))
        {
            controladoorQuadro.SetInteger("condicao", 1);
        }
    }
}
