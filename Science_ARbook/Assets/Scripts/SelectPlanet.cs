using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectPlanet : MonoBehaviour
{
    public Planet planet;
    Image img;
    public SelectPlanet[] planets;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        if(DataManger.instance.currentPlanet == planet)
        {
            OnSelect();
        }
        else
        {
            OnDeSelect();
        }
    }

    public void PanetButtonClick()
    {
        DataManger.instance.currentPlanet = planet;
        OnSelect();
        for(int i =  0; i < planets.Length; i++)
        {
            if(planets[i] != this)
            {
                planets[i].OnDeSelect();
            }
        }
    }

    void OnDeSelect()
    {
        img.color = new Color(0.5f, 0.5f, 0.5f);
    }

    void OnSelect()
    {
        img.color = new Color(1f, 1f, 1f);
    }
}
