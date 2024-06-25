using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class gamemanagercontrol : MonoBehaviour
{
    public puntoscontrol puntoscontrol;
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void Aumentar(float puntitos)
    {
        puntoscontrol.maspuntos(puntitos);
    }
    public void Pausar()
    {
        Time.timeScale = 0;
    }
    public void Continuar()
    {
        Time.timeScale = 1;
    }

}
