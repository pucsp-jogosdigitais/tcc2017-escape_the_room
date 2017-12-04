using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{

    Image painelFade;
    public string LevelToLoad = "Menu";
    //declaração de sigleton
    public static Fade fade;
    public AudioSource source;
    bool fadeAudio = false;
    Scene cenaAtual;

    public float fadeTimeInSeconds;



    void Awake()
    {
        fade = this;
    }
    void Start()
    {
    

        painelFade = GetComponent<Image>();
        painelFade.enabled = true;
        painelFade.CrossFadeAlpha(0.01f, 2, true);
        cenaAtual = SceneManager.GetActiveScene();
        if (cenaAtual.name == "Intro")
        {
            Invoke("fadeOut", 3);
        }
    }

    void fadeOut()
    {

        painelFade.CrossFadeAlpha(1, 2, true);
        Invoke("ChangeScene", 2);
        fadeAudio = true;

        if (fadeAudio)
        {
            source.volume = Mathf.Lerp(source.volume, 0, Time.deltaTime);
        }//será dado um fade quando mudar a tela, então a musica irá diminuir o volume e não irá cortar abruptamente*/
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(LevelToLoad);
    }

    public void ChangeScene(string level)
    {
        painelFade.CrossFadeAlpha(1, 2, true);
        LevelToLoad = level;
        Invoke("ChangeScene", 2);
    }
}

