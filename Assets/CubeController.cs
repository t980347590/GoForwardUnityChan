using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    private float a = -.2f;
    private float b = -10;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.a,0,0);
        if (transform.position.x < this.b)
        {
            Destroy(gameObject);
        }
    }


    //課題のために追加


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cube" || collision.gameObject.tag == "ground")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
