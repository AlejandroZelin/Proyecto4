using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class CreacionObjetos : MonoBehaviour
{
    public GameObject Arbol1;
    public GameObject Arbol2;
    public GameObject Casa;
    public GameObject Roca;

    public TextMeshProUGUI ArbolText;
    public TextMeshProUGUI Arbol2Text;
    public TextMeshProUGUI CasasText;
    public TextMeshProUGUI RocasText;

    GameObject crear;
    public int ValorObjeto { get; set; }

    void Start()
    {
        ValorObjeto = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Ray RayoCamara = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Paco;

        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(RayoCamara, out Paco, Mathf.Infinity))
            {
                if (Paco.collider.gameObject.CompareTag("Terreno"))
                {
                    Creacion();
                    Object.Instantiate(crear, Paco.point, crear.transform.rotation);
                }
            }
        }

        //No funcha = Lo tengo mal =)

        //Ray RayoCamaraDestroy = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit Fermin;

        //if (Input.GetMouseButtonDown(0)) 
        {
            //if (Physics.Raycast(RayoCamaraDestroy, out Fermin, Mathf.Infinity)) 
            {
                //if (Fermin.collider.gameObject.CompareTag("Arbol")) 
                {
                    //Destroy(Arbol1)
                }
            }
        }

        ArbolText.text = "Hay " + GameObject.FindGameObjectsWithTag("Arbol").Length + " arboles";
        Arbol2Text.text = "Hay " + GameObject.FindGameObjectsWithTag("Arbol2").Length + " arboles muertos";
        CasasText.text = "Hay " + GameObject.FindGameObjectsWithTag("Casa").Length + " casas";
        RocasText.text = "Hay " + GameObject.FindGameObjectsWithTag("Roca").Length + " rocas";
    }

    public void Creacion()
    {
        if (ValorObjeto == 0)
        {
            crear = Arbol1;
        }
        else if (ValorObjeto == 1)
        {
            crear = Arbol2;
        }
        else if (ValorObjeto == 2)
        {
            crear = Casa;
        }
        else if (ValorObjeto == 3)
        {
            crear = Roca;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward);
    }
}
