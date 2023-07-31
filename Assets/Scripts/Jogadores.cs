using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogadores : MonoBehaviour
{
    public float velocidadeJogadores;
    public float limiteMinimoY;
    public float limiteMaximoY;
    public bool jogador1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (jogador1 == true)
        {
            MovimentarJogador1();
        }
        else
        {
            MovimentarJogador2();
        }
    }

    private void MovimentarJogador1()
    {
        LimitarMovimentacaoDosJogadoresNoEixoY();

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * velocidadeJogadores * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * velocidadeJogadores * Time.deltaTime);
        }
    }

    private void MovimentarJogador2()
    {
        LimitarMovimentacaoDosJogadoresNoEixoY();

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * velocidadeJogadores * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * velocidadeJogadores * Time.deltaTime);
        }
    }

    private void LimitarMovimentacaoDosJogadoresNoEixoY()
    {
        transform.position = new Vector2(transform.position.x,
            Mathf.Clamp(transform.position.y, limiteMinimoY, limiteMaximoY));
    }
}
