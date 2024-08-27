using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Código : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(KeyCode.RightArrow))

                if (transform.position.x < 4.1)
                    transform.position += new Vector3(5f, 0, 0) * Time.deltaTime;
        }
        {
            if (Input.GetKey(KeyCode.LeftArrow))

                if (transform.position.x > -3.8)
                    transform.position += new Vector3(-5f, 0, 0) * Time.deltaTime;
        }
        {
            if (Input.GetKey(KeyCode.UpArrow))

                if (transform.position.y < 3.4)
                    transform.position += new Vector3(0, 5f, 0) * Time.deltaTime;
        }
        {
            if (Input.GetKey(KeyCode.DownArrow))
                if (transform.position.y > -0.4)
                    transform.position += new Vector3(0, -5f, 0) * Time.deltaTime;
        }
    }
}

