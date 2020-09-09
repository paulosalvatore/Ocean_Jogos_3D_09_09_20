using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{
    public Rigidbody rb;

    public float velocidade = 1f;

    public float velocidadeRotacao = 30f;

    // Update is called once per frame
    void Update()
    {
        var v = Input.GetAxis("Vertical") * velocidade;
        var h = Input.GetAxis("Horizontal") * velocidadeRotacao;

        rb.velocity = transform.forward * v;

        transform.Rotate(Vector3.up * h * Time.deltaTime);
    }
}
