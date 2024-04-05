using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveParticle : MonoBehaviour
{
    public float speedMove = 5f;
    void Start()
    {
        
    }
    void Update()
    {
        float horinput = Input.GetAxis("Horizontal"),
        verInput = Input.GetAxis("Vertical");

        Vector3 Direction = new Vector3(horinput, 0.0f, verInput);

        transform.Translate(Direction * speedMove * Time.deltaTime);

    }
}
