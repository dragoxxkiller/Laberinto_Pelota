using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovBola1 : MonoBehaviour
{
    /*public float torque;
    public float thrust;
    */
    Rigidbody rb;
    [SerializeField] float fuerza = 0.5f;
    float posY;

    private Vector3 cubePosition = new Vector3(0.05f, 0.0605f, -0.4405f);

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();



    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*rb.AddForce(transform.forward * thrust);

        float turn = Input.GetAxis("Horizontal");
        rb.AddTorque(transform.up * torque * turn);*/

        float desp1H = Input.GetAxis("Horizontal");
        float desp1V = Input.GetAxis("Vertical");

        rb.AddForce(Vector3.forward * desp1V * fuerza);
        rb.AddForce(Vector3.right * desp1H * fuerza);

        posY = transform.position.y;
        
        if(posY < -5)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
