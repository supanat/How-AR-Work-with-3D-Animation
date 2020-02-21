using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleUp : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 initScale;
    
    public float speed=2;

    private float currentScale = 0;

    void Start()
    {
        initScale = transform.localScale;


        transform.localScale = Vector3.zero;

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localScale.x < initScale.x){

            currentScale+= Time.deltaTime * speed;
            transform.localScale =  new Vector3(currentScale,currentScale,currentScale);
        }
    }
}
