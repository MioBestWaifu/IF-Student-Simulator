using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StressBarController : MonoBehaviour
{
    public Slider slider;
    private float tempoPassado = 0;
    // Start is called before the first frame update
    void Start()
    {
        switch(Definitions.jogadorStatus){
            case 0:
            break;
            case 1:
            break;
            case 2:
            break;
            case 3:
            break;
            case 4:
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        tempoPassado+=Time.deltaTime;
        if(tempoPassado>=1f){
            tempoPassado = 0;
            switch(Definitions.jogadorStatus){
            case 0:
            slider.value = slider.value + 0f;
            break;
            case 1:
            slider.value = slider.value + 1f;
            break;
            case 2:
            slider.value = slider.value + 2.5f;
            break;
            case 3:
            slider.value = slider.value - 0.6f;
            break;
            case 4:
            slider.value = slider.value - 1f;
            break;
        }
        }
    }
}
