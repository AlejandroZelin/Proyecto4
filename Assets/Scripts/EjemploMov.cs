using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploMov : MonoBehaviour
{

    public float sensibilidad = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ratonX = Input.GetAxis("Mouse X");
        float ratonY = Input.GetAxis("Mouse Y");
        this.transform.position = new Vector3(this.transform.position.x + ( ratonX * sensibilidad), 
            this.transform.position.y,
            this.transform.position.z + (ratonY * sensibilidad));
    }
}
