using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private int _score;
    private int _bestScore;
    [SerializeField] private TMP_Text lbl_Score;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        lbl_Score.text = "Score: " + _score;
        gameOver = false;
        _bestScore = PlayerPrefs.GetInt("bestScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        _score++;
        lbl_Score.text = "Score: " + _score;
    }

    public void setUpGameOver()
    {
        gameOver = true;

        if (_score > _bestScore)
        {
            PlayerPrefs.SetInt("bestScore", _score);   
        }
    }
}
