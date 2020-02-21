using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilator : MonoBehaviour
{

    float timeCounter = 0;
    public float speed = 2;
    public float radius_width = 4;
    public float radius_height = 4;
    
    
    private Vector3 initPosition;



    public enum AxisOfRotation
    {
        X,
        Y,
        Z
    };

    public AxisOfRotation axisOfRotation = AxisOfRotation.Y;

    void Start()
    {
        axisOfRotation = AxisOfRotation.Y;

        initPosition = transform.position;
    }
    void Update()
    {
        timeCounter += Time.deltaTime * speed;


        float x = 0;
        float y = 0;
        float z = 0;

        switch (axisOfRotation)
        {
            case AxisOfRotation.X:
                x = 0;
                y = Mathf.Sin(timeCounter) * radius_height;
                z = Mathf.Cos(timeCounter) * radius_width;
                break;

            case AxisOfRotation.Y:

                x = Mathf.Cos(timeCounter) * radius_width;
                y = 0;
                z = Mathf.Sin(timeCounter) * radius_height;
                break;


            case AxisOfRotation.Z:
                x = Mathf.Cos(timeCounter) * radius_width;
                y = Mathf.Sin(timeCounter) * radius_height;
                z = 0;
                break;

        }


        transform.position = initPosition + new Vector3(x, y, z);
    }


}
