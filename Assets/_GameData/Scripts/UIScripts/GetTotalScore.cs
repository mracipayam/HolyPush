using UnityEngine;
using TMPro;

public class GetTotalScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        scoreText.text = "Score : " + GameManager.instance.TotalScore.ToString();
    }
}
