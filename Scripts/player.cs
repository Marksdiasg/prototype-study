using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // we wiil move the vechicle forward kk
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
