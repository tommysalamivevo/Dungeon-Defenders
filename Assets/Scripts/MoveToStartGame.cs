using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToStartGame : MonoBehaviour
{
    public void nextScene()
    {
        SceneManager.LoadScene("StartGame");
    }
}
