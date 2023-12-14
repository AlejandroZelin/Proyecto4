using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject CamaraMenu;
    public GameObject CrearMenu;
    public GameObject MenuOpciones;
    public GameObject MoviCamara;
    public GameObject MenuBorrar;
    public GameObject Info;

    public bool ModoCreacion { get; set; }
    public bool camaraMode { get; set; }

    CreacionObjetos CreacionObjetos;

    void Start()
    {
        ModoCreacion = false;
        camaraMode = false;


        CreacionObjetos = GameObject.Find("Main Camera").GetComponent<CreacionObjetos>();
    }

    public void modoCreacion()
    {
        ModoCreacion = true;

        MenuOpciones.SetActive(false);
        CrearMenu.SetActive(true);
    }

    public void CamaraMode()
    {
        camaraMode = true;

        MenuOpciones.SetActive(false);
        CamaraMenu.SetActive(true);
    }

    public void exitModoCreacion()
    {
        camaraMode = false;

        CrearMenu.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void movCamara()
    {
        camaraMode = true;

        MenuOpciones.SetActive(false);
        MoviCamara.SetActive(true);
    }

    public void exitmovCamara()
    {
        camaraMode = false;

        MoviCamara.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void CrearArbol()
    {
        CreacionObjetos.ValorObjeto = 0;
    }

    public void CrearArbol2()
    {
        CreacionObjetos.ValorObjeto = 1;
    }

    public void CrearCasa()
    {
        CreacionObjetos.ValorObjeto = 2;
    }

    public void CrearRoca()
    {
        CreacionObjetos.ValorObjeto = 3;
    }

    public void PanelBorrar() 
    {
        camaraMode = false;

        MenuOpciones.SetActive(false);
        MenuBorrar.SetActive(true);
    }

    public void exitMenuBorrar() 
    {
        camaraMode = false;

        MenuBorrar.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void info() 
    {
        camaraMode = false;

        MenuOpciones.SetActive(false);
        Info.SetActive(true);
    }

    public void exitInfo() 
    {
        camaraMode = false;

        Info.SetActive(false);
        MenuOpciones.SetActive(true);
    }
}
