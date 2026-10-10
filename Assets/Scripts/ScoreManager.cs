using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public GameObject winPanel;
    private int totalCoins = 0;
    private int collectedCoins;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        winPanel.SetActive(false);
        totalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
        UpdateText();
    }
    void Update()
    {
        if(collectedCoins >= totalCoins)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void CollectCoin()
    {
        collectedCoins++;
        UpdateText();
        
    }
    private void UpdateText()
    {
        scoreText.text = $"Coins collected {collectedCoins}/{totalCoins}";
    }
}
