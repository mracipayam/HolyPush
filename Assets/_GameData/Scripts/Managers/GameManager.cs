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
    public int inGameCountdownTime;

    public bool canPlay;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        
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
        inGameCanvas.SetActive(false);
        joystickCanvas.SetActive(false);
        gameOverCanvas.SetActive(true);
        yield return new WaitForSeconds(1);

    }





}
