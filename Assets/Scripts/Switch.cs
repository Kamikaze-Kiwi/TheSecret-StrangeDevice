using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool status = false;
    public bool savedStatus = false;

    public void Toggle()
    {
        status = !status;
        transform.Rotate(0, 0, 180);
        SwitchHandler.instance.IsCorrectCombination();
    }

    public void SaveStatus()
    {
        savedStatus = status;
    }
}
