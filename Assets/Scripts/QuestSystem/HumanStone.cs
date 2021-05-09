using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanStone : MonoBehaviour
{
    [SerializeField] GameObject quests;
 

    private void Start()
    {

        quests = GameObject.Find("Quest");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        quests.AddComponent<StoneQuest>();
    }
}

