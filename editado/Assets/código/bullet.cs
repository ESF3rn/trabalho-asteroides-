using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    private void  OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
