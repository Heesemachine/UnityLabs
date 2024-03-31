using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{

    [SerializeField] private Text coinsText;
    private void Start()
    {
        int coins = PlayerPrefs.GetInt("coins");
        coinsText.text = coins.ToString("Total earned coins:" + coins);

    }

    public void PlayGame()
    {
        SceneManager.LoadScene(0);
    }

    public void ShowRecordsTable()
    {
        SceneManager.LoadScene(3);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(2);
    }
}
