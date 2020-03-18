using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalVariable : MonoBehaviour
{
    static readonly string TIMEVARIABLE = "_Time_Period";

    public Slider slider;

    public void NewValue()
    {
        Debug.Log(slider.value);
        Shader.SetGlobalFloat(TIMEVARIABLE, slider.value);
    }
}
