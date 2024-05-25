// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezareto

// Projeto Interdisciplinar - Ci�ncia da Computa��o

// C�digo para abrir menu de op��es

// Bibliotecas empregadas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opcoes : MonoBehaviour
{
    // Declara��o de vari�veis 
    [SerializeField] private GameObject painelDeVolume;
    [SerializeField] private GameObject painelDeOpcoes;

    public void AbrirOpcoes() //Abre o menu de opc�es
    {
        painelDeOpcoes.SetActive(true);
        painelDeVolume.SetActive(false);
    }

    public void AbrirVolume() //Abre o menu de altera��o volume
    {
        painelDeOpcoes.SetActive(false);
        painelDeVolume.SetActive(true);
    }
}
