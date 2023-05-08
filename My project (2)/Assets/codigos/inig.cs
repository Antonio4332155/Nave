using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inig : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rig;

    public float temp;

    private float medis;
    public int damage = 1;
    public int vida;
    public Animation anim;

    public bool Tempooor = true;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animation>();

    }

    private void FixedUpdate()
    {
        medis += Time.deltaTime;
        if (medis >= temp)
        {
            Tempooor = !Tempooor;
            medis = 0f;
        }

        if (Tempooor)
        {
            transform.eulerAngles = new Vector2(0, 180);
            rig.velocity = Vector2.right * speed;
        }
        else
        {
            transform.eulerAngles = new Vector2(0, 0);
            rig.velocity = Vector2.left * speed;
        }

    }

    public void Damage(int dmg)
    {
        vida -= dmg;


        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void SetWalkDirection(Vector2 left)
    {
        throw new System.NotImplementedException();
    }
}
