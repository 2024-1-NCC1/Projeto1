// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezareto

// Projeto Interdisciplinar - Ciência da Computação

// Código para música de fundo

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
        if (!somFundoSource.isPlaying) // Se música não estiver tocando, ativar
        {
            somFundoSource.PlayOneShot(somFundo); // Áudio de fundo
        }

    }
    public void volumeMusical(float value) //Altera o valor do áudio do jogo
    {
        somFundoSource.volume = value;
    }
}
