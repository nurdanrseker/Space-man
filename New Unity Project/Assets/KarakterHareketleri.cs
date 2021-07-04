using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareketleri : MonoBehaviour
{
    /*  public float yatayhareket;
      public float dikeyhareket;*/

    protected Joystick joystick;
    public int harekethizi;

    // Rigidbody2D rb;

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        //    rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = new Vector3(joystick.Horizontal * 100f * harekethizi, rigidbody.velocity.y, joystick.Vertical * 100f * harekethizi);
    }
}
/*
void Update()
    {

        yatayhareket = Input.GetAxis("Horizontal");
        dikeyhareket = Input.GetAxis("Vertical");

        //Rigidbodynin hareketi, uygulanan kuvvet //rb.velocity yazdýðýmýz yerde eskiden neyse o kalsýn demek oluyor. Kod deðiþebilir
        rb.velocity = new Vector2(yatayhareket*harekethizi * 100 * Time.deltaTime, rb.velocity.y);
        rb.velocity = new Vector3(dikeyhareket*harekethizi * 100 * Time.deltaTime, rb.velocity.x);
    }
}*/
