using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private float a = -.03f;
    private float b = -16;
    private float c = 15.8f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.a, 0, 0);
        if (transform.position.x < this.b)
        {
            transform.position = new Vector2(this.c, 0);
        }

    }
}
