using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    public float sensibilidad = 6f;

    public GameObject MenuOpciones;
    public GameObject MoviCamara;

    Manager manager;

    void Start()
    {
        manager = GameObject.Find("ManagerBoton").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.camaraMode)
        {
            Movimiento();
        }
    }

    public void Movimiento()
    {
        float ratonX = Input.GetAxis("Mouse X");
        float ratonY = Input.GetAxis("Mouse Y");
        this.transform.position = new Vector3(this.transform.position.x + (ratonX * sensibilidad), this.transform.position.y, this.transform.position.z + (ratonY * sensibilidad));
    }
}
