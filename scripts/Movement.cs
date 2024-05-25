// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezareto

// Projeto Interdisciplinar - Ciência da Computação

// Código para movimentar players e ativar partículas

// Bibliotecas empregadas

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    // Declaração de variáveis 
    [SerializeField] float impulsoPrincipal = 500f;
    [SerializeField] float rotationImpulso = 50f;
    [SerializeField] AudioClip bolhasSom;
    [SerializeField] ParticleSystem bolhasParticulaPrincipal;
    [SerializeField] ParticleSystem bolhasEsquerda;
    [SerializeField] ParticleSystem bolhasDireita;
    Rigidbody rb;
    AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        audioSource = GetComponent<AudioSource>();

    }
    
    void Update()
    {
        ChamarImpulso(); // Impulso principal

        ChamaRotation(); // Impulso para rotações

    }

    void ChamarImpulso()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartImpulso(); // Tecla space inicia a função para começar impulso
        }
        else
        {
            StopImpulso(); // Caso não, paralizar impulso principal
        }
    }

    void ChamaRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            RotateLeft(); // Rotação para esquerda
        }

        else if (Input.GetKey(KeyCode.D))
        {
            RotateRight(); // Rotação para direita
        }

        else
        {
            StopRotating(); // Paralizar rotaçõess
        }
    }

    void StartImpulso()
    {
        rb.AddRelativeForce(Vector3.up * impulsoPrincipal * Time.deltaTime);

        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(bolhasSom); // Áudio principal
        }

        if (!bolhasParticulaPrincipal.isPlaying)
        {
            bolhasParticulaPrincipal.Play(); // Partículas principais
        }
    }

    private void StopImpulso()
    {
        audioSource.Stop();
        bolhasParticulaPrincipal.Stop();
    }

    private void RotateLeft()
    {
        ApplyRotation(rotationImpulso);

        if (!bolhasDireita.isPlaying)
        {
            bolhasDireita.Play(); // Ativar partículas para esquerda
        }
    }

    private void RotateRight()
    {
        ApplyRotation(-rotationImpulso);

        if (!bolhasEsquerda.isPlaying)
        {
            bolhasEsquerda.Play(); // Ativar partículas para direita
        }
    }

    private void StopRotating()
    {
        bolhasDireita.Stop();
        bolhasEsquerda.Stop();
    }

    void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true;  // Paralizando rotação

        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);

        rb.freezeRotation = false;  // Voltando rotação
    }
}