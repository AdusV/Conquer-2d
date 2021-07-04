using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusQuest1 : Quest
{
    [SerializeField] GameObject cactus;

    private void Awake()
    {
        questName = "Kaktus";
        questDescription = "Zbierz kaktus sam  ";
        questObjective = new CollectionObjective(this, 1, "cactus");
    }

    void Start()
    {
        cactus = GameObject.Find("cactus");
        cactus.SetActive(false);
    } 
    
    public override void Finished()
    {
        PlayerStats.Instance.UpdateRegenerationRate(3);
        base.Finished();
    }

    public override void SetActive()
    {
        base.SetActive();
        cactus.SetActive(true);
    }

    public void PickupEvent()
    {
        if (isActive)
        {
            Finished();
        }
    }
}
