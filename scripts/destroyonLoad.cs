// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezareto

// Projeto Interdisciplinar - Ci�ncia da Computa��o

// Bibliotecas empregadas
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyonLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
