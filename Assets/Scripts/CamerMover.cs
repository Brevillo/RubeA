using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerMover : MonoBehaviour
{
    // class variables
    [Tooltip("The speed of the camera movement")]
    public float Speed = 10;
    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 direction = Vector3.zero;

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        

        transform.position += direction * Speed * Time.deltaTime;
        */

        if(Target != null)
        {
            Vector3 newPos = Target.transform.position;
            newPos.z = transform.position.z;
            transform.position = newPos;
        }
        
    }
}
