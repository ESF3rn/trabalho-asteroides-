using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class fireeeeeeeee : MonoBehaviour
{
    float speed = 20;

    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Mata", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
       transform.position+= transform.up * Time.deltaTime * speed;
        
    }
    
    void Mata()
    {
        Destroy(gameObject);
    }
}