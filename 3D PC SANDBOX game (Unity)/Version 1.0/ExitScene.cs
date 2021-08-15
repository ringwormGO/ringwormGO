using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScene : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}