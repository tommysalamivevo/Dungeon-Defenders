using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    public int scene = 0;

    public void nextScene()
    {
        SceneManager.LoadScene(scene);
    }
}
