using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
    public int speed = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0); //rotates 50 degrees per second around z axis
    }
}
