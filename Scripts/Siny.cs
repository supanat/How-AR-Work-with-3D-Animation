using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siny : MonoBehaviour {
 
    public float rate = 0.1f;
     public float midScale =1f ;
     public float ratio = 2f;
 
    // Drag this game object onto this variable slot.
    // It makes the code run faster than using "transform" by itself.
 
    //alternatively, if it is the owning object that gets the scale changes, you can get it automatically, on Start
    //this checks to see if it the variable thisTransform is assigned, and if it isn't, assigns it to the current transform.
    void Start(){



        
    }
 
    private Vector3 scale;
    void Update ()
    {
        float scaleComponent = midScale * Mathf.Pow(ratio, Mathf.Sin(Time.time * rate));
        for (int i = 0; i < 3; i++) {
            scale = scaleComponent*Vector3.one;
            transform.localScale = scale;
        }
    }
 
        //Alternatively, you could use Mathf.PingPong...
 
 
        void PingPong(){
            transform.localScale=Mathf.PingPong(Time.time*rate,ratio)*Vector3.one;
        }
    }
