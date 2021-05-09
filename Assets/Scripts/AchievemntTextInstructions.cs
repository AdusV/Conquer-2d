using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievemntTextInstructions : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("Hide", 5);
    }
    void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
