using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Para podermos usar comandos de interface de usuario
using UnityEngine.UI;
// Comandos de carregamento de cena
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pontuacaoJogador1;
    public int pontuacaoJogador2;
    public AudioSource somGol;
    public Text textoPlacar;
    public bool jogoPausado;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Quando reinicio, por algum motivo a velocidade da bolinha é reduzida, percebi que se eu manter a tecla R pressionada por um tempo o jogo é reiniciado na velocidade correta.
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReiniciarJogo();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SairDoJogo();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            jogoPausado = !jogoPausado;

            if (jogoPausado == true)
            {
                PausarJogo();
            }
            else
            {
                DespausarJogo();
            }
        }
    }

    private void DespausarJogo()
    {
        Time.timeScale = 1;
    }

    private void PausarJogo()
    {
        Time.timeScale = 0;
    }

    private void ReiniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // FindAnyObjectByType<Bola>().MovimentarBola();
    }

    private void SairDoJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do jogo!");
    }

    public void AumentarPontuacaoJogador1()
    {
        pontuacaoJogador1 += 1;
        AtualizarTextoPlacar();
    }

    public void AumentarPontuacaoJogador2()
    {
        pontuacaoJogador2 += 1;
        AtualizarTextoPlacar();
    }

    public void AtualizarTextoPlacar()
    {
        somGol.Play();
        textoPlacar.text = pontuacaoJogador1 + " x " + pontuacaoJogador2;
    }
}
