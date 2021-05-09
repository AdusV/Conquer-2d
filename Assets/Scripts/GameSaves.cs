using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSaves : MonoBehaviour
{
    public static GameSaves Instance = null;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        Instance = this;
    }

    public void SaveGameState()
    {
        PlayerPrefs.SetInt("points", PlayerStats.Instance.Points);
        PlayerPrefs.SetInt("xp", PlayerStats.Instance.LevelXp);
        PlayerPrefs.SetInt("grzybobranie",Convert.ToInt32(Achievements.Instance.grzyb.isCompleted));

    }
    public void LoadGameState()
    {
        if (PlayerPrefs.HasKey("points"))
        {

           PlayerStats.Instance.Points = PlayerPrefs.GetInt("points");
        }

        if (PlayerPrefs.HasKey("xp"))
        {

            PlayerStats.Instance.LevelXp = PlayerPrefs.GetInt("xp");
        }

        if (PlayerPrefs.HasKey("grzybobranie"))
        {

            bool isCompleted =Convert.ToBoolean(PlayerPrefs.GetInt("grzybobranie"));
            if(isCompleted)
            {
                Achievements.Instance.ActivateGrzyb();
            }
        }
    }
}
