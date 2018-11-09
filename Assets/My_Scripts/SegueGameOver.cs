using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SegueGameOver : MonoBehaviour
{

    void OnTriggerEnter(Collider coll)
    {
        if (coll.name.Contains("Player"))
        {
            SceneManager.LoadScene("Win");
        }
    }
}
