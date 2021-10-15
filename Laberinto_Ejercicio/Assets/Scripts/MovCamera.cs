using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamera : MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] GameObject playerObject;

    [SerializeField] float smoothVelocity = 0.1F;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;
    [SerializeField] Transform playerPosition;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       // Vector3 targetPosition = new Vector3(playerPosition.transform.position.x, playerPosition.transform.position.y + 0.2f, playerPosition.transform.position.z - 0.3f);
        Vector3 targetPosition = new Vector3(playerPosition.transform.position.x , playerPosition.transform.position.y + 0.3f, playerPosition.transform.position.z -0.2f );
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);

    }
}
