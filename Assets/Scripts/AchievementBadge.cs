using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AchievementBadge : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI instructionText;
    [Multiline] 
    [SerializeField] string textOfInstruction;
    [SerializeField] Image badgeBackground;
    [SerializeField] Image badge;
    public bool isCompleted;

    public void ShowInstruction()
    {
        if (!isCompleted)
        {
        instructionText.text = textOfInstruction;
        instructionText.transform.parent.gameObject.SetActive(true);

        }
    }
    public void ActivateBadge()
    {
        badgeBackground.color = Color.white;
       // badge.color = Color.white;
        isCompleted = true;
        Destroy(GetComponent<Button>());
    }

}
