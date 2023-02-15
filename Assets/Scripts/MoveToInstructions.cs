using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToInstructions : MonoBehaviour
{
    public void nextScene()
    {
        SceneManager.LoadScene("Instructions");
    }
}
