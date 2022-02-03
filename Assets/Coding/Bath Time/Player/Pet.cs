using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour, IClicker
{
    public void onClickAction()
    {
        Debug.Log("Clicking Pet");
    }
}
