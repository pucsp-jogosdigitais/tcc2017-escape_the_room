using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOverNavigation : MonoBehaviour
{

    public Fade fade;
    public GameObject arrow;
    public Text restart;
    public Text quit;
    int index = 0;
    Vector3 arrowPosition;

    void Start()
    {
        //arrowPosition = new Vector3(restart.transform.position.x, restart.transform.position.y - 25, 0);
        arrow.transform.position = arrowPosition;
    }

    void Update()
    {
        if (Input.GetKeyDown("down") && index == 0)
        {
            index++;
            arrowPosition = new Vector3(quit.transform.position.x, quit.transform.position.y - 25, 0);
            arrow.transform.position = arrowPosition;
        }
        if (Input.GetKeyDown("up") && index == 1)
        {
            index--;
            arrowPosition = new Vector3(restart.transform.position.x, restart.transform.position.y - 25, 0);
            arrow.transform.position = arrowPosition;
        }
        if (Input.GetKeyDown("return") && index == 0)
        {
            fade.ChangeScene("level1");
        }
        if (Input.GetKeyDown("return") && index == 1)
        {
            Application.Quit();
        }
    }
}
