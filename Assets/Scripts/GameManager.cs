using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private int score;
    [SerializeField] private TMP_Text lbl_Score;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        lbl_Score.text = "Score: " + score;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        score++;
        lbl_Score.text = "Score: " + score;
    }

    public void setUpGameOver()
    {
        gameOver = true;
    }
}
