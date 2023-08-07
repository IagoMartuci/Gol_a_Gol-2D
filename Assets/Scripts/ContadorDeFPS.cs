using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorDeFPS : MonoBehaviour
{
    // Header: cabe�alho para melhor organiza��o do Inspector na Unity
    [Header("Contador")]
    // SerializeFied permite que a Unity "visualize" a variavel no Inspector
    [SerializeField] private float taxaDeAtualizacaoDoContador;
    private float quantidadeDeFPS;

    [Header("UI")]
    [SerializeField] private Text textoDoContadorDeFPS;

    // Start is called before the first frame update
    private void Start()
    {
        // Chama o metodo ContarFPSDoJogo repetida vezes de acordo com o tempo que desejarmos, diferente do Update que chama uma vez por frame
        InvokeRepeating(nameof(ContarFPSDoJogo), 0f, taxaDeAtualizacaoDoContador); // Metodo, quando inicia, qual sera a taxa de atualiza��o
    }

    // Update is called once per frame
    private void Update()
    {
        // ContarFPSDoJogo();
    }

    private void ContarFPSDoJogo()
    {
        // 1f / Time.deltaTime (Time.deltaTime armazena quanto tempo se passou entre um frame e outro, e quando dividimos por 1 segundo que � o 1f, temos o FPS)
        quantidadeDeFPS = 1f / Time.deltaTime;
        // Mathf.Floor pega o menor n�mero (base), exemplo: 500.375 vai trazer s� 500
        textoDoContadorDeFPS.text = Mathf.Floor(quantidadeDeFPS).ToString() + " FPS";
    }
}
