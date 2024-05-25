// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezareto

// Projeto Interdisciplinar - Ciência da Computação

// Código para movimentar obstáculos

// Bibliotecas empregadas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // Declaração de variáveis
    Vector3 valorInicial;
    [SerializeField] Vector3 movementVector;
    float movementFactor;
    [SerializeField] float period = 2f;
    
    void Start()
    {
        valorInicial = transform.position;
    }

    void Update()
    {
        if (period <= Mathf.Epsilon) 
        { 
            return;
        }

        float ciclos = Time.time / period;  // Continuação de ciclos
        
        const float tau = Mathf.PI * 2;  

        float onda = Mathf.Sin(ciclos * tau);  // Movimentação de "-1" até "1"

        movementFactor = (onda + 1f) / 2f; // Recalculando para ir de 0 até 1 (suavização de movimento)
        
        Vector3 offset = movementVector * movementFactor;
        
        transform.position = valorInicial + offset;
    }
}
