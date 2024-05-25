// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezareto

// Projeto Interdisciplinar - Ci�ncia da Computa��o

// C�digo para pausar o jogo

// Bibliotecas empregadas
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    // Declara��o de vari�veis 
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
