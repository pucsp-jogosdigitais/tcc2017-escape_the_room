using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class AlternateMouse : MonoBehaviour {
    public FirstPersonController fpc;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire4"))
        {
            fpc.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            if (Input.GetButton("Fire1"))
            {
                clickevent();
            }
        }
        else
        {
            fpc.enabled = true;

        }
	}


    void clickevent()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point);
            if (hit.collider.gameObject.tag.Equals("Interact"))
            {
                hit.collider.gameObject.SendMessage("Ativate", SendMessageOptions.DontRequireReceiver);
            }
        }

    }
}

