using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBanditQuest : Quest
{
    [SerializeField] GameObject bandit;
    
    // Start is called before the first frame update
    void Start()
    {
        bandit = GameObject.Find("Enemy-Bandit");
        // bandit.SetActive(false);
    } 
    
    // public override void SetActive()
    // {
    //     base.SetActive();
    //     bandit.SetActive(true);
    // }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KillBanditEvent()
    {
        if (isActive)
        {
            isFinished = true;
        }
    }
}
