using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusQuest1 : Quest
{
    private void Awake()
    {
        questName = "Kaktus";
        questDescription = "Zbierz kaktus sam  ";
        questObjective = new CollectionObjective(this, 1, "cactus");
    }

    public override void Finished()
    {
        PlayerStats.Instance.UpdateRegenerationRate(3);
        base.Finished();
    }

}
