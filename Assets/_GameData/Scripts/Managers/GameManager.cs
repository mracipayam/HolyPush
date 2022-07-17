using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public GameObject startGameCanvas;
    public GameObject joystickCanvas;
    public GameObject inGameCanvas;
    public GameObject gameOverCanvas;
    public TextMeshProUGUI inGameCountdownDisplay;
    public TextMeshProUGUI inGameDiamondDisplay;
    public int inGameCountdownTime;
    public int inGameDiamond;
    public int PointAreaOneX;
    public int PointAreaThreeX;
    public int PointAreaFiveX;
    public int TotalScore;
    

    public bool canPlay;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void UpdateInGameDiamondDisplay()
    {
        inGameDiamondDisplay.text = inGameDiamond.ToString();
    }

    public void PlayButtonClicked()
    {
        startGameCanvas.SetActive(false);
        joystickCanvas.SetActive(true);
        inGameCanvas.SetActive(true);
        canPlay = true;
        StartCoroutine(InGameCountdown());
    }

    public void ReturnToMainMenuButtonClicked()
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator InGameCountdown()
    {
        while (inGameCountdownTime > 0)
        {
            inGameCountdownDisplay.text = inGameCountdownTime.ToString();
            yield return new WaitForSeconds(1);
            inGameCountdownTime--;
        }

        GameManager.instance.canPlay = false;
        CalculateScore();
        inGameCanvas.SetActive(false);
        joystickCanvas.SetActive(false);
        gameOverCanvas.SetActive(true);
        yield return new WaitForSeconds(1);

    }

    public void CalculateScore()
    {
        TotalScore = (10 * PointAreaOneX) + (30 * PointAreaThreeX) + (50 * PointAreaFiveX);
    }




}
