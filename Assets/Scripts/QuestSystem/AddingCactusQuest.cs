using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingCactusQuest : MonoBehaviour
{
    [SerializeField] GameObject quests;

    private void Start()
    {
        quests = GameObject.Find("Quest");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        quests.GetComponent<QuestStorage>().AddQuest(typeof(CactusQuest1));
    }
}
