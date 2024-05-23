using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class RotationAroundAPoint : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform Point;
    public float radious;
    public float speed;

    float time;
    Vector3 rotationPointOrigin;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationPointOrigin = Point.transform.position;

        time += Time.deltaTime;
        if (time > (1/speed) * 2 * Mathf.PI) 
        { 
            time = 0; 
        }

        Debug.Log(time);

        transform.position = new Vector3(radious * Mathf.Cos(speed * time) + rotationPointOrigin.x, transform.position.y + rotationPointOrigin.y, radious * Mathf.Sin(speed * time) + rotationPointOrigin.z);
    }
}
