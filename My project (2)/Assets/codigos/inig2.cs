using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inig2 : MonoBehaviour
{
    [SerializeField] private int hp;

    [SerializeField] private Sprite mySprite;
    [SerializeField] private float changeDirctionTime;

    private SpriteRenderer _spriteRenderer;

    private Vector2 walkdirection;

    private float _currentChangeTime;

    private Animator ingm;
    // Start is called before the first frame update
    void Start()
    {
        ingm = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveDirection();
        CountTime();
    }

    public void Initialize(int hp, Sprite sprite)
    {
        this.hp = hp;
        mySprite = sprite;

        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        _spriteRenderer.sprite = mySprite;
    }

    public void SetWalkDirection(Vector2 direction)
    {
        walkdirection = direction;
    }

    public void MoveDirection()
    {
        transform.Translate((Vector3)(walkdirection * Time.deltaTime));
    }

    public void CountTime()
    {
        if(_currentChangeTime <= changeDirctionTime)
        {
            _currentChangeTime += Time.deltaTime;
        }
        else
        {
            _currentChangeTime = 0;
            ingm.SetTrigger("controling");
        }
    }
    
    }


