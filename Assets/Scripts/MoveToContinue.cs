using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToContinue : MonoBehaviour
{
    public void nextScene()
    {
        SceneManager.LoadScene("Continue");
    }
}
