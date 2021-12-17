using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Move : MonoBehaviour
{
    private bool right = true;
    public float speed = 2.0f;
    [DllImport("Movefast")]
    private static extern int Movefast();
    // Start is called before the first frame update
    void Start()
    {
        speed = speed + Movefast();
    }

    // Update is called once per frame
    void Update()
    {
        if(right)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }

        if(transform.position.x >= 4.0f)
        {
            right = false;
        }
        if (transform.position.x <= -4)
        {
            right = true;
        }
    }
}
