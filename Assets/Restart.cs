using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Text restartUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        { 
            SceneManager.LoadScene("Main Menu");
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
        }
    }
}
