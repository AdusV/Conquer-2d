using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour
{
    [SerializeField] AchievementBadge Polnoc;
    [SerializeField] AchievementBadge Grzyb;
    public AchievementBadge grzyb
    { 
        get { return Grzyb; } 
    }
    [SerializeField] AchievementBadge Zachod;
    [SerializeField] AchievementBadge Wrog;

    /// *******************
    public static Achievements Instance = null;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        Instance = this;
    }


    /// *******************
    public void ActivatePolnoc()
    {
        Polnoc.ActivateBadge();
    }
    public void ActivateGrzyb()
    {
        Grzyb.ActivateBadge();
        NotificationSystem.Instance.AddNotification("Przyznano odznake \"Grzybobranie\".");

    }
    public void ActivateZachod()
    {
        Zachod.ActivateBadge();
    }
    public void ActivateWrog()
    {
        Wrog.ActivateBadge();
    }



}

