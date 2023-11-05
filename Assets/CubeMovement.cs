using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(10f * Vector3.forward * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(10f * Vector3.back * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(10f * Vector3.left * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(10f * Vector3.right * Time.deltaTime);
    }
}
