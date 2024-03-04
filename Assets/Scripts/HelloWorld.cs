using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int speed = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
    }
}
