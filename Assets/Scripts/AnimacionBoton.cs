using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionBoton : MonoBehaviour
{
    public GameObject Boton;
    void Start()
    {
        LeanTween.moveLocal(Boton, new Vector3(3, 3, 1), 1).setEaseInElastic().setLoopPingPong(1);
    }
}
