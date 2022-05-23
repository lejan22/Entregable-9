using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class DataPersistance : MonoBehaviour
{
    
    //getting

    public float GetFloat(string key)
    {
        return PlayerPrefs.GetFloat(key);
    }

    public string GetString(string key)
    {
        return PlayerPrefs.GetString(key);
    }

    public int GetInt(string key)
    {
        return PlayerPrefs.GetInt(key);
    }

    //setting

    public void SetFloat(string key, float value)
    {
        PlayerPrefs.SetFloat(key, value);
        PlayerPrefs.Save();
    }
    
    public void SetString(string key, string value)
    {
        PlayerPrefs.SetString(key, "value");
        PlayerPrefs.Save();
    }

    public void SetInt(string key, int value)
    {
        PlayerPrefs.SetInt(key, value);
        PlayerPrefs.Save();
    }








    public bool HasKey(string key)
    {
        return PlayerPrefs.HasKey(key);
    }

    public void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
    }
}
