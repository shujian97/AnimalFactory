using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PandaMovement3 : MonoBehaviour
{

    public float waitTime = 5.0f;
    private float timer = 0.0f;
    Vector3 backRotation = new Vector3(0, 0, 0);
    Vector3 frontRotation = new Vector3(0, 180, 0);
    private int counter = 0;
   // public GameObject explosion = (GameObject)Resources.Load("Prefabs/Explosion", typeof(GameObject));

    void OnCollisionEnter()
    {
        
        //GameObject exploder = ((GameObject)Instantiate(explosion, this.transform.position,
         //   this.transform.rotation)).gameObject;
       // Destroy(exploder, 2.0f);
        Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        //transform.eulerAngles = newRotation;
    
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > waitTime && counter == 0)
        {
            transform.eulerAngles = backRotation;
            timer = timer - waitTime;
            counter = 1;
            Debug.Log("Panda Rotated Back");
        }

        if(timer > waitTime && counter == 1)
        {
            transform.eulerAngles = frontRotation;
            timer = timer - waitTime;
            counter = 0;
            Debug.Log("Panda Rotated Front");

        }
    }
    
    
}
