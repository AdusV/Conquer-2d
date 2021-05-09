using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tent : MonoBehaviour
{
    [SerializeField] GameObject quests;
    [SerializeField] GameObject allien;

    private void Start()
    {
        
        quests = GameObject.Find("Quest");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        allien.AddComponent<AddingCactusQuest>();   
        quests.AddComponent<PinkDiamondQuest>();
    }
}
