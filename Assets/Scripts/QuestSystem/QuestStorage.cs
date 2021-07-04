using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public class QuestStorage : MonoBehaviour
{

    [SerializeField] public List<Quest> Quests = new List<Quest>();
    // Start is called before the first frame update
    private void Start()
    {
        Quests = new List<Quest>();
        var guests = Assembly
            .GetAssembly(typeof(Quest))
            .GetTypes()
            .Where(t => t.IsSubclassOf(typeof(Quest)));
        
        foreach (var guest in guests)
        {
            gameObject.AddComponent(guest);
        }
        AddQuest(typeof(PickUpMushrooms));
        AddQuest(typeof(KillBanditQuest));
        
    }

    public void AddQuest(Type quest)
    {
        if (Quests.Any(q => q.GetType() == quest))
        {
            return;
        }

        var questResult = gameObject.GetComponent(quest) as Quest;
        
        Quests.Add(questResult);
        questResult.SetActive();
        NotificationSystem.Instance.AddNotification($"Otrzymałes misje: {questResult.questName}"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
