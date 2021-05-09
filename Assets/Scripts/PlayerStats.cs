using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int healthTime;  
     public int HealthTime
     {
         get { return healthTime; }

     }

    [SerializeField] private int maxHealthTime;
    [SerializeField] private int regenerationRate;
    [SerializeField] private int levelXP = 1;
    public int LevelXp
    { 
        get { return levelXP; }
        set { levelXP = value; }
    }

    [SerializeField] private int points = 0;
    [SerializeField] private int healthIncreaseByXPLevel;

    [SerializeField] private int[] pointsForXPLevels;
    [Header("Interfejs")]
    [SerializeField] Image healthBar;
    [SerializeField] TextMeshProUGUI pointsText;

    public int Points
    {
        get { return points; }
        set { points = value; }
    }


    /// *******************
    public static PlayerStats Instance = null;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        Instance = this;
    }


    /// *******************
    private void Start()
    {
        InvokeRepeating("UpdateHealthBarUI", 0, 0.1f);
    }
    public void Regeneration()
    {
        healthTime = Mathf.Clamp(healthTime + regenerationRate, 0, maxHealthTime);
        Debug.Log(healthTime);
    }
    public void AddPoints(int pointsToAdd)
    {
        points += pointsToAdd;
        Debug.Log($"punkty{points}");

        if (points > pointsForXPLevels[levelXP] && levelXP < pointsForXPLevels.Length -1) 
        {
            levelXP++;
            points = 0;

            maxHealthTime += healthIncreaseByXPLevel;
        }
        UpdatePointsTextUI();
    }
    public void UpdateHealthTime(int valueToSub)
    {
        healthTime -= valueToSub;
       
    }
    
    public void UpdateRegenerationRate(int valuetoAdd)
    {
        regenerationRate += valuetoAdd;
        //Debug.Log($"Nowa wartosc regeneracji to {regenerationRate}");
    }
    void UpdateHealthBarUI()
    {
        healthBar.fillAmount = healthTime / (float) maxHealthTime;
    }
    void UpdatePointsTextUI()
    {
        pointsText.text = points.ToString();
    }

}
