using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    private int score;
    public Text scoreText;
    public GameObject gameMenu;

    // Start is called before the first frame update

    private void Awake() {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameStart() {
        gameMenu.SetActive(false);
        scoreText.gameObject.SetActive(true);
    }

    public void Restart() {

        SceneManager.LoadScene("GamePlay");

    }
     public void ScoreUp() {

        score++;
        scoreText.text = score.ToString();

    }
}
