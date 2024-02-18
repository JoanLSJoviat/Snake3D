using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private int _score;
    private int _bestScore;
    [SerializeField] private TMP_Text _lbl_Score;
    [SerializeField] private TMP_Text _gameOverLbl;
    [SerializeField] private GameObject _menuBtn;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        _lbl_Score.text = "Score: " + _score;
        gameOver = false;
        _bestScore = PlayerPrefs.GetInt("bestScore");
        _gameOverLbl.text = "";
        _menuBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        _score++;
        _lbl_Score.text = "Score: " + _score;
    }

    public void setUpGameOver()
    {
        gameOver = true;
        _gameOverLbl.text = "GAME OVER";
        _menuBtn.SetActive(true);

        if (_score > _bestScore)
        {
            PlayerPrefs.SetInt("bestScore", _score);   
        }
    }

    public void backToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
