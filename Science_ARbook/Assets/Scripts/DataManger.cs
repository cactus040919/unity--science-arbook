using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Planet
{
    Mercury, Venus, Earth, Mars
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
