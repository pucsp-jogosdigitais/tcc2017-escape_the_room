using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    int min = 3;
    float sec = 0;
    bool fim;

    void Start()
    {
        fim = false;
    }

    void FixedUpdate()
    {
        if (Time.timeScale == 1)
        {
            sec -= 1 * Time.deltaTime;
        }

        if (sec < 0)
        {
            if (!fim)
            {
                min--;
                sec = 59;
            }

            if (fim)
            {
                //gameover
                Time.timeScale = 0;
                SceneManager.LoadScene("Game Over");
            }
            
        }

        if (min == 0)
        {
            fim = true;
        }
    }

    private void OnGUI()
    {
        GUI.skin.box.fontSize = Screen.height / 20;
        GUI.Box(new Rect(Screen.width - Screen.width / 6, Screen.height - Screen.height / 1.1f, Screen.width / 10, Screen.height / 20), min.ToString("00") + ":" + sec.ToString("00"));
    }
}