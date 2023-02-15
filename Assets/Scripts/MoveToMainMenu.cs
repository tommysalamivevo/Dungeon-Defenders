using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToMainMenu : MonoBehaviour
{
    public void nextScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
