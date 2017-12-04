using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHAVE : MonoBehaviour
{
    public int IDdaChave;
    public float DistanciaDaChave = 3;
    public AudioClip somChave;
    private bool PegouChave;
    private GameObject Jogador;
    void Start()
    {
        PegouChave = false;
        Jogador = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, Jogador.transform.position) < DistanciaDaChave)
        {
			if (Input.GetButtonDown("Fire1") && PegouChave == false)
            {
                PORTA.ListaDeIDs.Add(IDdaChave);
                PegouChave = true;
                GetComponent<MeshRenderer>().enabled = false;
                GetComponent<AudioSource>().PlayOneShot(somChave);
                Destroy(gameObject, 0.05f);
            }
        }
    }
}