using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Planet
{
   Sun, Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
}

public class DataManger : MonoBehaviour
{
    public static DataManger instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else if (instance != null)
        {
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    public Planet currentPlanet;
}
