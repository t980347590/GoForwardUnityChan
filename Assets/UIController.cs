using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    private GameObject a;
    private GameObject b;
    private float c=0;
    private float d = .03f;
    private bool e = false;

    private void Start()
    {
        this.a = GameObject.Find("GameOver");
        this.b = GameObject.Find("RunLength");

    }
    private void Update()
    {
        if (this.e == false)
        {
            this.c += this.d;
            this.b.GetComponent<Text>().text = "Distance: " + c.ToString("F2") + "m";

        }

        if (this.e == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("GameScene");
            }
        }
    }
    public void GameOver()
    {
        this.a.GetComponent<Text>().text = "GameOver";
        this.e = true;
    }

}