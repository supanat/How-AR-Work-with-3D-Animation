using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{

    public GameObject targetObject;
    public float speed=2;
    // Start is called before the first frame update

    
    public enum AxisOfRotation
    {
        X,
        Y,
        Z
    };

    public AxisOfRotation axisOfRotation = AxisOfRotation.Y;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        


        switch (axisOfRotation)
        {
            case AxisOfRotation.X:
               transform.RotateAround(targetObject.transform.position, Vector3.right, speed*Time.deltaTime);
                break;

            case AxisOfRotation.Y:

                transform.RotateAround(targetObject.transform.position, Vector3.up, speed*Time.deltaTime);
                break;


            case AxisOfRotation.Z:
                
                transform.RotateAround(targetObject.transform.position, Vector3.forward, speed*Time.deltaTime);

                break;

        }

    }
}
