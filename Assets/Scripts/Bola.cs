using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    // public bool jogoIniciado;
    public float velocidadeBola;
    //public float direcaoAleatoriaX;
    //public float direcaoAleatoriaY;
    public Rigidbody2D oRigidbody2D;
    public AudioSource somBola;

    // Start is called before the first frame update
    void Start()
    {
        MovimentarBola();
        // jogoIniciado = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Não funciona bem, por algum motivo diminui a velocidade da bolinha
        //if(jogoIniciado == false)
        //{
        //    if(Input.GetKeyDown(KeyCode.Space))
        //    {
        //        MovimentarBola();
        //        jogoIniciado = true;
        //    }
        //}
    }

    public void MovimentarBola()
    {
        // Adicionando movimentação na bolinha com base na velocidade através dos eixos x e y
        oRigidbody2D.velocity = new Vector2(velocidadeBola, velocidadeBola) * Time.deltaTime;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        somBola.Play();
        // oRigidbody2D.velocity += new Vector2(direcaoAleatoriaX, direcaoAleatoriaY) * Time.deltaTime;
    }
}
