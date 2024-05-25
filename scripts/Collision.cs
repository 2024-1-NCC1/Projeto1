// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezareto

// Projeto Interdisciplinar - Ciência da Computação

// Código para detectar colisões, ativar aúdios e partículas, trocar e recarregar níveis

// Bibliotecas empregadas

using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using System.Threading.Tasks;

public class CollisionDetector : MonoBehaviour
{

    // Declaração de variáveis: 
    
    [SerializeField] float faseDelay = 2f;
    [SerializeField] AudioClip success;
    [SerializeField] AudioClip crash;
    [SerializeField] ParticleSystem successParticles;
    [SerializeField] ParticleSystem crashParticles;
    AudioSource audioSource;
    bool mudaFase = false;
    bool semColisao = false;

    void Start() 
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    void Update() 
    {
        Controle();    
    }

    void Controle()
    {

        // Função para testes 
        
        if (Input.GetKeyDown(KeyCode.L))
        {
            NextLevel(); // Tecla "L" para carregar próximo nível
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            semColisao = !semColisao;  // Tecla "C" para desabilitar colisão
        } 
    }

    void OnCollisionEnter(Collision other) 
    {
        if (mudaFase || semColisao) 
        { 
            return; // "Quebra" de função
        }
        
        switch (other.gameObject.tag)
        {
            case "Start":
                Debug.Log("Área segura!"); // Tag "start" para área segura do jogo
                break;

            case "Final":
            FinalDeFase(); // Tag "final" para área de finalização do jogo
                break;

            default:
                DestruirFoguete(); // Nenhuma tag, logo, destruir o foguete
                break;
        }
    }

    void FinalDeFase()
    {
        mudaFase = true;
        audioSource.Stop();
        audioSource.PlayOneShot(success); // Tocar música de "sucesso"
        successParticles.Play(); // Ativar partículas de "sucesso"
        GetComponent<Movement>().enabled = false; // Desativar movimentos do personagem
        Invoke("NextLevel", faseDelay); // Carregar próximo nível 
    }

    void DestruirFoguete()
    {
        mudaFase = true;
        audioSource.Stop();
        audioSource.PlayOneShot(crash); // Tocar música de "destruição"
        crashParticles.Play(); // Ativar partículas de "destruição"
        GetComponent<Movement>().enabled = false; // Desativar movimentos do personagem
        Invoke("ReloadLevel", faseDelay); // Recarregar o nível
    }

    void NextLevel()
    {
        // Função para habilitar a troca de níveis

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        Thread.Sleep(2000); // Delay para trocar de fase
        SceneManager.LoadScene(nextSceneIndex);
    }

    void ReloadLevel()
    {

        // Função para recarregar nível, em caso de destruição do personagem

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

}
