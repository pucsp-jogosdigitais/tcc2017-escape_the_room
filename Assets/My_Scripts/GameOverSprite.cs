using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverSprite : MonoBehaviour {

    public Image sonic;
    public Sprite[] idleAnim;
    float idleIndex = 0;

	void Update () {
        Anim();
	}

    void Anim()
    {
        idleIndex += Time.deltaTime * 2;
        if (idleIndex >= idleAnim.Length) idleIndex = 0;
        sonic.sprite = idleAnim[(int)idleIndex];
    }
}
