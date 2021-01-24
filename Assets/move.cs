using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MLAPI.NetworkedBehaviour
{

    float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (this.IsOwner)
        {
            float x = Input.GetAxis("Horizontal") * speed;
            float z = Input.GetAxis("Vertical") * speed;
            this.transform.position += new Vector3(x, 0, z);
        }
    }
}
