using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public TMP_InputField inputfield;
    public TMP_InputField updatedInputfield;
    public AudioSource audiosource;
    public Slider slider;
    private DataPersistance dataPersistence;
    private string DefaultFavonum ="34" ;
    private void Start()
    {
       
        dataPersistence = FindObjectOfType<DataPersistance>();
        loadsettings();
    }


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
        PlayerPrefs.SetFloat("Music Volume", volume);
    }

    public void GetMusicVolume()
    {
        // Si no existe, guarda un valor predeterminado
        if (!dataPersistence.HasKey("Music Volume"))
        {
            SetVolume(1);
        }

        // Obtiene el valor guardado
        slider.value = PlayerPrefs.GetFloat("Music Volume");
    }

    public void changeVolume(float volume)
    {

        audiosource.volume = volume;
    }

    //Para salir del juego al tener la build hecha, tiene el debuglog para ver si funciona
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Que se te haga leve");
    }



    public void setnumfavo(string numero)
    {
        PlayerPrefs.SetString("Numfavo", numero);
    }

    public void Getnumfavo()
    {
        if (!dataPersistence.HasKey("NumFavo"))
        {
            setnumfavo(DefaultFavonum);
        }
        inputfield.text = PlayerPrefs.GetString("NumFavo");
    }
   

    public void Play(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }

    private void loadsettings()
    {
        GetMusicVolume();
        Getnumfavo();
    }
}
