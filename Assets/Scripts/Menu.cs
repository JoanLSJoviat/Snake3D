using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
   
    public TMP_Text bestScore;
    void Start()
    {
        bestScore.text = "BEST SCORE: " + PlayerPrefs.GetInt("bestScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
            SceneManager.LoadScene(1);
    }
}
