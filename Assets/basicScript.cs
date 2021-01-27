using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicScript : MonoBehaviour
{
    public Vector3 rotation = new Vector3(0, 3.2f, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            GetComponent<Transform>().Rotate(rotation);
        }
    }
}
