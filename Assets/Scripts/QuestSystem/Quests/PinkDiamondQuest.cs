using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkDiamondQuest  : Quest
{
    private void Awake()
    {
        questName = "Rozowy diament";
        questDescription = "Zbierz diament sam  ";
        questObjective = new CollectionObjective(this, 1, "pinkDiamond");
    }

    public override void Finished()
    {
        PlayerStats.Instance.UpdateRegenerationRate(3);
        base.Finished();
    }

}
