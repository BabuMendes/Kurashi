using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kurashi : MonoBehaviour
{

    public Rigidbody2D Corpo;
    public float velocidade;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
        Apontar();
    }

    void Mover()
    {
        velocidade = Input.GetAxis("Horizontal") * 4;
        Corpo.velocity = new Vector2(velocidade, Corpo.velocity.y);
    }

    void Apontar()
    {

    }
}
