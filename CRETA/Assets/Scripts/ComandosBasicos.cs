using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandosBasicos : MonoBehaviour
{
    public int velocidade;
    private Rigidbody2D PedraFOFA;
    public float ForcaPulo;

    public bool sensor;
    public Transform PosicaoSensor;
    public LayerMask LayerChao;
    private anim;

    // Start is called before the first frame update
    void Start()
    {
        PedraFOFA = GetComponent<Animator>();
        PedraFOFA = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimentox = Input.GetAxisRaw("Horizontal");

        PedraFOFA.velocity = new Vector2(movimentox * velocidade, PedraFOFA.velocity.y);

        Animation.SetInteger("walk", (int)movimentox);

        if (Input.GetButtonDown("Jump") && sensor == true)
        {
            PedraFOFA.AddForce(new Vector2(0, ForcaPulo));
        }
    }



    private void FixedUpdate()
    {
        sensor = Physics2D.OverlapCircle(PosicaoSensor.position, 0.1f, LayerChao);
    }
}

