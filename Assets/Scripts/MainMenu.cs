using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("ArtMuseum");
    }

    public void VRRoom()
    {
        SceneManager.LoadScene("3DDrawingSpace");
    }

    public void ArtRoom()
    {
        SceneManager.LoadScene("2DDrawingSpace");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
