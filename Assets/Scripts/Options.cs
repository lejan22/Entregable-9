using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{


    public Slider slider;
    
    
    //Para entrar en la pantalla de opciones
    public void showup()
    {
        gameObject.SetActive(true) ;
    }

    //Para salir de la pantalla de opciones
    public void ExitOpt()
    {
        gameObject.SetActive(false);
    }

    //Para hacer que el slider tenga los mismos valores que la musica
    public void SetVolume(float volume)
    {
        slider.value = volume;
    }
    //Para salir del juego al tener la build hecha, tiene el debuglog para ver si funciona
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Que se te haga leve");
    }


}
