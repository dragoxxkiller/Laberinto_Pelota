using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escena_niv2 : MonoBehaviour
{
    [SerializeField] float fuerza;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float desp1H = Input.GetAxis("Horizontal");
        float desp1V = Input.GetAxis("Vertical");

        rb.AddTorque(new Vector3(0.1f, 0f, 0f) * desp1V * fuerza);
        rb.AddTorque(new Vector3(0f, 0f, 0.1f) * desp1H * fuerza);
    }
}
