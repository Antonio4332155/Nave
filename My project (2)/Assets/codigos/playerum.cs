using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerum : MonoBehaviour
{
    public Rigidbody2D rigidboby;


    public float velocidadeMovimento;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");


        float velocidadeX = (horizontal * this.velocidadeMovimento);
        float velocidadeY = (vertical * this.velocidadeMovimento);


        this.rigidboby.velocity = new Vector2(velocidadeX, velocidadeY);

    }
}
