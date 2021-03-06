﻿using UnityEngine;
using System.Collections;

public class PlayerMoviment : MonoBehaviour {

    public float speed;                //Variavel flutuante para guardar o valor da velocidade do player.

    private Rigidbody2D rb2d;        //Guarda a referencia do componente Rigidbbody2D requerido para usar física 2d.

    // Use this for initialization
    void Start()
    {
        //Pega e armazena a referencia do componente Rigidbody2D para que possa acessa-la.
        rb2d = GetComponent<Rigidbody2D> ();
    }

    //FixedUpdate é chamado para que ter um intervalo fixo independentemente do frame rate. Coloque o código de física aqui.
    void FixedUpdate()
    {
        //Armazena a atual tecle "INPUT" horizontal na variavel FLUTUANTE moveHorizontal.
        float moveHorizontal = Input.GetAxis ("Horizontal");

        //Armazena a atual tecle "INPUT" vertical na variavel FLUTUANTE moveVertical.
        float moveVertical = Input.GetAxis ("Vertical");

        //Use as duas variaveis flutuantes (moveHorizontal, moveVertical) para criar uma variavel  VECTOR 2 de movimento.
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

        //Chame a função AddForce function para nosso Rigidbody2D rd2d para fornecer movimento multiplicando a velocidade para mover o player.
        rb2d.AddForce (movement * speed);
    }
}
