using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarraMoviment : MonoBehaviour
{
    public int garra_movespeed;
    public AudioSource garra_audioMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {

        GarraMove();
        Garrasound();

    }
    void GarraMove()

    {
        if (Input.GetKey(KeyCode.I))
        {
            transform.position += new Vector3(0, 0.1f, 0);
            
        }
        

        if (Input.GetKey(KeyCode.K))
        {
            transform.position += new Vector3(0, -0.1f, 0);
            
        }
        
        
        if (Input.GetKey(KeyCode.J))
        {
            transform.position += new Vector3(-0.1f, 0, 0);
            
        }
        
        if (Input.GetKey(KeyCode.L))
        {
            transform.position += new Vector3(0.1f, 0, 0);
         
        }
        
        
        
    }
    void Garrasound()
    {
        if (Input.GetKey(KeyCode.L) || Input.GetKey(KeyCode.I) || Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.K))
        {
            garra_audioMove.volume = 0.2f;
        }
        else
        {
            garra_audioMove.volume = 0;
        }
    }


}

