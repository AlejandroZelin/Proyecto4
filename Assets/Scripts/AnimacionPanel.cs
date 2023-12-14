using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionPanel : MonoBehaviour
{
    public GameObject Panel;
    void Start()
    {
        LeanTween.moveLocal(Panel, new Vector3(2, 2, 1), 1).setEaseInExpo().setLoopPingPong(1);
    }
}
