using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{
    public Rigidbody rb;

    public float velocidade = 1f;

    public float velocidadeRotacao = 30f;

    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        var v = Input.GetAxis("Vertical") * velocidade;
        var h = Input.GetAxis("Horizontal") * velocidadeRotacao;

        var movimento = transform.forward * v;
        rb.velocity = new Vector3(movimento.x, rb.velocity.y, movimento.z);

        //if (rb.velocity.magnitude > 0)
        //{
            transform.Rotate(Vector3.up * h * Time.deltaTime);
        //}

        anim.SetFloat("velocidade", rb.velocity.magnitude);
    }
}
