// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezareto

// Projeto Interdisciplinar - Ciência da Computação

// Código para abrir menu de opções

// Bibliotecas empregadas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Declaração de variáveis 
    [SerializeField] GameObject menu;
    [SerializeField] GameObject creditos;
    public void Iniciar(int indexScene) //Inicia o jogo
    {
        SceneManager.LoadSceneAsync(indexScene);
    }

    public void Opcoes(int indexScene) //Abre o menu de opçoes
    {
        SceneManager.LoadSceneAsync(indexScene);
    }

    public void AbrirCreditos() //Abre o menu de créditos
    {
        creditos.SetActive(true);
        menu.SetActive(false);
    }

    public void FecharCreditos() //Fecha o menu de créditos
    {
        creditos.SetActive(false);
        menu.SetActive(true);
    }

    public void Sair() //Sai do jogo
    {
        Application.Quit();
        Debug.Log("SAIUUUU");
    }
    
}
