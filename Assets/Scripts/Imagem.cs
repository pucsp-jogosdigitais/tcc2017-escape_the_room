using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Imagem : MonoBehaviour
{

    public Image imagem;
    bool iSwitch;
	bool onCollision;

    // Use this for initialization
    void Start()
    {

        imagem.enabled = false;
		onCollision = false;

    }

	void OnTriggerEnter(Collider other)
	{
		onCollision = true;
	}

	void OnTriggerExit(Collider other)
    {
		onCollision = false;
        imagem.enabled = false;
    }

    private void Update()
    {
		if (onCollision) {
			if (Input.GetButtonDown ("Fire1") && !iSwitch) {
				imagem.enabled = !imagem.enabled;
				iSwitch = true;
				return;
			}
			if (Input.GetButtonDown ("Fire1") && iSwitch) {
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
            GUI.Box(new Rect(280, 180, 200, 25), "Aperte 'E' para ler o papel ");
            /*if (Input.GetKeyDown(KeyCode.E))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    imagem.enabled = true;
                    onTrigger = false;
                }
            }*/
        }

    }
}
