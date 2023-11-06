using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Vector3 inputVector;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inputVector = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y += 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x -= 1;
        }

        inputVector = inputVector.normalized;

        //Debug.Log("Local position" + transform.InverseTransformPoint(inputVector));

        transform.localPosition += 5 * inputVector * Time.deltaTime;

        Vector3 moveDir = new Vector3(-inputVector.x, 0f, -inputVector.y);

        transform.forward = Vector3.Slerp(new Vector3(transform.forward.x,0, transform.forward.z), moveDir, Time.deltaTime * 5);
    }
}