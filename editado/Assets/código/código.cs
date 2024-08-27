using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rdb;
    public float velocidade = 1f;
    public SpriteRenderer fogo1, fogo2;

    public GameObject bulletPrefab;
    public Transform firepoint;

    float timerTiro;
    [SerializeField] float tiroDelay;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }
    void Update()
    {
        Tiro();
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        {
            Movimentos();
        }

        void Movimentos()
        {
            if (Input.GetKey(KeyCode.D)) //se aperta a tecla D
            {
                rdb.AddTorque(-velocidade); //adiciona torque para a direita
            }
            if (Input.GetKey(KeyCode.A))
            {
                rdb.AddTorque(velocidade);
            }
            if (Input.GetKey(KeyCode.W))
            {
                rdb.AddRelativeForce(Vector2.up * velocidade);
                fogo1.enabled = true;
                fogo2.enabled = true;
            }
            else
            {
                fogo1.enabled = false;
                fogo2.enabled = false;
            }

            
        }

        
    }
    void Tiro()
    {
        if (timerTiro <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
                timerTiro = tiroDelay;
            }
        }
        timerTiro-= Time.deltaTime;

    }
}