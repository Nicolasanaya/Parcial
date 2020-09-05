using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeCod : MonoBehaviour
{
    //public static PersonajeCod instancia;
    public float velocity = 1;
    private Rigidbody2D rb;
    //private Animator animator;

    public Controlador controlador;
    // private void awake()
    // {
    //     instancia = this;
    // }
    // Start is called before the first frame update
    void Start()
    {
    
        rb=GetComponent<Rigidbody2D>();
       // animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
        
    }
    // public void estado()
    // {
    //     animator.SetBool("Vida",false);
    // }
    // public void estadodos()
    // {
    //     animator.SetBool("Vida",false);
    // }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        controlador.Perdiste();

    }
}
