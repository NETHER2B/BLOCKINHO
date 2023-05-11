using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandosBasicos : MonoBehaviour
{
    public int velocidade;
    private Rigidbody2D PedraFOFA;
    public float forcaPulo;

    public bool sensor;
    public Transform posicaoSensor;
    public LayerMask layerChao; 

    // Start is called before the first frame update
    void Start()
    {
        PedraFOFA = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimentox = Input.GetAxisRaw("Horizontal");

        PedraFOFA.velocity = new Vector2(movimentox * velocidade, PedraFOFA.velocity.y);

        if (Input.GetButtonDown("Jump") && sensor == true)
        {
            PedraFOFA.AddForce(new Vector2(0, forcaPulo));
        }
    }



    private void FixedUpdate()
    {
        sensor = Physics2D.OverlapCircle(posicaoSensor.position, 0.1f, layerChao);
    }
}

