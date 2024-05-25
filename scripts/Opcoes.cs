// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezareto

// Projeto Interdisciplinar - Ciência da Computação

// Código para abrir menu de opções

// Bibliotecas empregadas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opcoes : MonoBehaviour
{
    // Declaração de variáveis 
    [SerializeField] private GameObject painelDeVolume;
    [SerializeField] private GameObject painelDeOpcoes;

    public void AbrirOpcoes() //Abre o menu de opcões
    {
        painelDeOpcoes.SetActive(true);
        painelDeVolume.SetActive(false);
    }

    public void AbrirVolume() //Abre o menu de alteração volume
    {
        painelDeOpcoes.SetActive(false);
        painelDeVolume.SetActive(true);
    }
}
