// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezareto

// Projeto Interdisciplinar - Ci�ncia da Computa��o

// C�digo para m�sica de fundo

// Bibliotecas empregadas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorSons : MonoBehaviour
{
    //Declarando variaveis
    [SerializeField] AudioClip somFundo;
    AudioSource somFundoSource;

    void Start()
    {

        somFundoSource = GetComponent<AudioSource>(); // Acessar AudioSource

    }

    void Update()
    {
        if (!somFundoSource.isPlaying) // Se m�sica n�o estiver tocando, ativar
        {
            somFundoSource.PlayOneShot(somFundo); // �udio de fundo
        }

    }
    public void volumeMusical(float value) //Altera o valor do �udio do jogo
    {
        somFundoSource.volume = value;
    }
}
