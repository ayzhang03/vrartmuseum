using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class DoorNextScene : MonoBehaviour
{
    public void NextScene()
    {
        Debug.Log("Loading next scene");
        SceneManager.LoadScene("3DDrawingSpace");
    }
}
