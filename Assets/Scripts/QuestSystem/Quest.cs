using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public string questName;
    public string questDescription;
    public bool isFinished = false;
    public bool isActive = false;
    public QuestObjective questObjective;
    public virtual void Finished()
    {
        isFinished = true;
;        Debug.Log($"Zadanie {questName} zaliczone.");
    }

    public virtual void SetActive()
    {
        isActive = true;
    }
}
