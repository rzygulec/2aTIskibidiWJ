using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] float VectorX;
    [SerializeField] float VectorY = 0;
    [SerializeField] float VectorZ;
    [SerializeField] float BaseSpeed = 3;
    [SerializeField] float Currentspeed;
    [SerializeField] float Sprint = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VectorX = Input.GetAxis("Horizontal");
        VectorY = Input.GetAxis("Vertical");
        Transform.Translate(VectrorX * Time.deltaTime * Currentspeed, VectorY * Time.deltaTime * Currentspeed, VectorZ * Time.deltaTime * (Currentspeed))


        if (Input.GetKey(KeyCode.LeftShift))
        {
            Currentspeed* BaseSpeed +Sprint;
        }
        else {
            Currentspeed = BaseSpeed;


            }
    }
}

