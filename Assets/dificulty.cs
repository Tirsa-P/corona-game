using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dificulty : MonoBehaviour
{
    // Start is called before the first frame update


    public void GameEasy()
    {
        SceneManager.LoadScene("Game_easy");
    }

    public void GameNormal()
    {
        SceneManager.LoadScene("Game_Normal");
    }

    public void GameHard()
    {
        SceneManager.LoadScene("Game_hard");
    }
}
