using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandosBasicoss : MonoBehaviour
{
    private Rigidbody2D rbPlayer;
    public int Velocidade;
    public int forcaPulo;
    private float inputMovimentoHorizontal;


    public bool senso;
    public Transform posicaoSensor;
    public LayerMask layerChao;
    void Start()
    {
       
        float movimentoX = Input.GetAxisRaw("Horizontal");

        rbPlayer.velocity = new Vector2(movimentoX * Velocidade, rbPlayer.velocity.y);
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
