using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{

    public GameObject a;
    private float b = 0;
    private float c = 1.0f;
    private float d = 12;
    private float e = .3f;
    private float f = 6.9f;
    private float g = .5f;
    private float h = .4f;
    private int k = 4;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.b += Time.deltaTime;
        if (this.b > this.c)
        {
            this.b = 0;
            int n = Random.Range(1, k + 1);
            for(int i = 0; i < n; i++)
            {
                GameObject l = Instantiate(a) as GameObject;
                l.transform.position = new Vector2(this.d, this.e + i * this.f);
            }
            this.c = this.g + this.h * n;
        }
    }
}
