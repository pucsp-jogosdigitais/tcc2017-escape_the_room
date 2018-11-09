using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LOAD : MonoBehaviour
{

    public string cenaCarregar;
    public bool autoload = false;
    public float TempoFixoSeg = 2;
    public enum TipoCareeg { Carregamento, TempoFixo };
    public TipoCareeg TipoDeCarregamento;
    public Image barraDeCarregamento;
    public Text TextoProgresso;
    private int Progresso = 0;
    private string textoOriginal;

    // Use this for initialization
    void Start()
    {
        if(autoload)
        {
            StartCoroutine(CenaDeCarregamento("Level 1"));
        }

        switch (TipoDeCarregamento)
        {
            case TipoCareeg.Carregamento:
                StartCoroutine(CenaDeCarregamento(cenaCarregar));
                break;
            case TipoCareeg.TempoFixo:
                StartCoroutine(TempoFixo(cenaCarregar));
                break;
        }

        if (TextoProgresso != null)
        {
            textoOriginal = TextoProgresso.text;
        }
        if (barraDeCarregamento != null)
        {
            barraDeCarregamento.type = Image.Type.Filled;
            barraDeCarregamento.fillMethod = Image.FillMethod.Horizontal;
            barraDeCarregamento.fillOrigin = (int)Image.OriginHorizontal.Left;
        }
    }

    IEnumerator CenaDeCarregamento(string cena)
    {
        AsyncOperation carregamento = SceneManager.LoadSceneAsync(cena);
        while (!carregamento.isDone)
        {
            Progresso = (int)(carregamento.progress * 100.0f);
            yield return null;
        }
    }

    IEnumerator TempoFixo(string cena)
    {
        yield return new WaitForSeconds(TempoFixoSeg);
        SceneManager.LoadScene(cena);
    }
    // Update is called once per frame
    void Update()
    {

        switch (TipoDeCarregamento)
        {
            case TipoCareeg.Carregamento:
                break;
            case TipoCareeg.TempoFixo:
                Progresso = (int)(Mathf.Clamp((Time.time / TempoFixoSeg), 0.0f, 1.0f) * 100.0f);
                break;
        }
        if (TextoProgresso != null)
        {
            TextoProgresso.text = textoOriginal + " " + Progresso + "%";
        }
        if (barraDeCarregamento != null)
        {
            barraDeCarregamento.fillAmount = (Progresso / 100.0f);
        }

    }
}
