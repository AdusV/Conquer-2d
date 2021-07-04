using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpMushrooms : Quest
{

    private int count = 5;
    private void Awake()
    {
        questName = "Zbierz grzyby";
        questDescription = "Zbierz 5 grzybów";
    }
    
    public override void Finished()
    {
        Achievements.Instance.ActivateGrzyb();
        base.Finished();
    }

    public void PickupEvent()
    {
        if (isActive)
        {
            count--;
            if(count <= 0)
                Finished();
        }
    }
}
