using UnityEngine;
using System.Collections;
using System.Security.Cryptography;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

    public Text guessText;
    public int maxGuesesAllowed = 10;

    private int max;
    private int min;
    private int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        
        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max+1);
        guessText.text = guess.ToString();
        maxGuesesAllowed -= 1;

        if (maxGuesesAllowed <= 0)
            SceneManager.LoadScene("Win");
    }
}
