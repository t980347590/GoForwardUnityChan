using UnityEngine;
using System.Collections;

public class UnityChanController : MonoBehaviour
{
    Animator a;
    private float b = -3.0f;

    Rigidbody2D d;
    private float e = .8f;
    float f = 20;

    private float g = -9;


    private void Start()
    {
        this.a = GetComponent<Animator>();
        this.d = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        this.a.SetFloat("Horizontal", 1);
        bool c = (transform.position.y > this.b) ? false : true;
        this.a.SetBool("isGround", c);

        GetComponent<AudioSource>().volume = (c) ? 1 : 0;


        if (Input.GetMouseButtonDown(0) && c)
        {
            this.d.velocity = new Vector2(0, this.f);
        }
        if (Input.GetMouseButton(0) == false)
        {
            if (this.d.velocity.y > 0)
            {
                this.d.velocity *= this.e;
            }
        }

        if (transform.position.x < this.g)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            Destroy(gameObject);
        }

    }
}