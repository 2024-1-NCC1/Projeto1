// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezareto

// Projeto Interdisciplinar - Ciência da Computação

// Código para 

// Bibliotecas empregadas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject menuInicial;
    public GameObject menuOpcoes;

    public void AbrirMenu()
    {
        menuOpcoes.SetActive(true);
        menuInicial.SetActive(false);
    }
}
