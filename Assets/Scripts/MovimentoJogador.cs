using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{
    public Rigidbody rb;

    public float velocidade = 1f;

    // Update is called once per frame
    void Update()
    {
        var v = Input.GetAxis("Vertical") * velocidade;

        rb.velocity = Vector3.forward * v;
    }
}
