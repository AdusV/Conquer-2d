using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpMushrooms : Quest
{
    private void Awake()
    {
        questName = "Zbierz grzyby";
        questDescription = "Zbierz 5 grzybów";
        questObjective = new CollectionObjective(this,5, "mushroom");
    }
    private void Start()
    {
    }
    public override void Finished()
    {
        
        Achievements.Instance.ActivateGrzyb();
        base.Finished();
    }

}
