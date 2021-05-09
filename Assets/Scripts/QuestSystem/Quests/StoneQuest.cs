using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneQuest : Quest
{
    private void Awake()
    {
        questName = "Kamień";
        questDescription = "Zniszcz kamień";
        questObjective = new CollectionObjective(this,1,"stone");     
    }
    public override void Finished()
    {
        base.Finished();
    }
}
