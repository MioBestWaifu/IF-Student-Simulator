using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Relogio : MonoBehaviour
{
    private TMP_Text text;
    private float tempoPassado;
    private int horas, minutos;

    public float TempoPassado { get => tempoPassado; set => tempoPassado = value; }

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<TMP_Text>();
        TempoPassado = 0;
        horas = 0;
        minutos = 0;
        text.text = horas + " : " + minutos;
    }

    // Update is called once per frame
    void Update()
    {
        TempoPassado+= Time.deltaTime;
        if(TempoPassado>=1f){
            minutos+=5;
            TempoPassado = 0;
        }
        if(minutos == 60){
            minutos = 0;
            horas += 1;
        }

        if(horas== 24){
            horas = 0;
        }
        if (minutos<10 && horas<10){
            text.text ="0"+ horas + " : " +"0"+ minutos;
        } else if (minutos <10){
            text.text = horas + " : "+"0" + minutos;
        } else if (horas<10){
            text.text = "0"+ horas + " : " + minutos;
        } else {
            text.text = horas + " : " + minutos;
        }
    }
}
