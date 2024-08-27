using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {

            Destroy(collision.collider.gameObject);
        }

        Destroy(gameObject);

    }
}
