// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezareto

// Projeto Interdisciplinar - Ci�ncia da Computa��o

// C�digo para abrir menu de op��es

// Bibliotecas empregadas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Declara��o de vari�veis 
    [SerializeField] GameObject menu;
    [SerializeField] GameObject creditos;
    public void Iniciar(int indexScene) //Inicia o jogo
    {
        SceneManager.LoadSceneAsync(indexScene);
    }

    public void Opcoes(int indexScene) //Abre o menu de op�oes
    {
        SceneManager.LoadSceneAsync(indexScene);
    }

    public void AbrirCreditos() //Abre o menu de cr�ditos
    {
        creditos.SetActive(true);
        menu.SetActive(false);
    }

    public void FecharCreditos() //Fecha o menu de cr�ditos
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
