using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("StartPage");
    }

    public void Reset3D()
    {
        SceneManager.LoadScene("3DDrawingSpace");
    }

    public void Reset2D()
    {
        SceneManager.LoadScene("2DDrawingSpace");
    }
}
