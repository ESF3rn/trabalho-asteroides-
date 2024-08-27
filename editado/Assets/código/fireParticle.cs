using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireParticle : MonoBehaviour
{
    public ParticleSystem particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Fire();
        }
    }
    void Fire()
    {
        particleSystem.Emit(1);
    }
}
