using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchHandler : MonoBehaviour
{
    public static SwitchHandler instance;

    public SwitchHandler()
    {
        instance = this;
    }

    public List<Switch> switches;
    public Image lampElement;

    public void IsCorrectCombination()
    {
        foreach (Switch sw in switches)
        {
            if (sw.status != sw.savedStatus)
            {
                lampElement.color = Color.black;
                return;
            }
        }

        lampElement.color = Color.yellow;
    }

    public void SaveStatusses()
    {
        foreach (Switch sw in switches)
        {
            sw.SaveStatus();
        }

        lampElement.color = Color.yellow;
    }
}
