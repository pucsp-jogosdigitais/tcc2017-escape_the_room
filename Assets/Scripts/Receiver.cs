using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour {
    public float distanciaParaAbrir = 3;

    public bool EstaTrancada { get; private set; }
    public bool PodeAbrir { get; private set; }
    public GameObject Jogador { get; private set; }
    public bool MovimentarPorta { get; private set; }
    public int CronometroMovimento { get; private set; }
    public object EstaAberta { get; private set; }
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void Ativate()
    {
        print("funciona!!!");
        if (Vector3.Distance(transform.position, Jogador.transform.position) <= distanciaParaAbrir)
        {
            PodeAbrir = true;
        }
        else if (Vector3.Distance(transform.position, Jogador.transform.position) > distanciaParaAbrir)
        {
            PodeAbrir = false;
        }

        if (EstaTrancada == false)
        {
			if (Input.GetButtonDown("Fire1") && MovimentarPorta == true && PodeAbrir == true)
            {
                CronometroMovimento = 1;
                EstaAberta = EstaAberta;
            }
			else if (Input.GetButtonDown("Fire1") && PodeAbrir == true && MovimentarPorta == false)
            {
                MovimentarPorta = true;
            }
        }

    }

}
