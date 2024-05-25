// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezareto

// Projeto Interdisciplinar - Ciência da Computação

// Código para pausar o jogo

// Bibliotecas empregadas
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    // Declaração de variáveis 
    [SerializeField] GameObject menuPause;
    [SerializeField] GameObject botaoPause;

    public void AbrirPause() //Abre o menu de pause
    {
        menuPause.SetActive(true);
        botaoPause.SetActive(false);
    }

    public void FecharPause() //Fecha o menu de pause
    {
        menuPause.SetActive(false);
        botaoPause.SetActive(true);
    }

    public void Sair(int indexScene) //Voltar par o menu inicial
    {
        SceneManager.LoadSceneAsync(indexScene);
    }
}
