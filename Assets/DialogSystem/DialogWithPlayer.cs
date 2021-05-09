using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogWithPlayer : MonoBehaviour
{
    [SerializeField] Dialog dialog;
    [SerializeField] TextMeshProUGUI textUI;
    private void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(ChangeDialogWords());
    }
    
    IEnumerator ChangeDialogWords()
    {
        for (int i = 0; i < dialog.dialogText.Length; i++)
        {
            textUI.text = dialog.dialogText[i];
            yield return new WaitForSeconds(2);  
        }
        textUI.text = "";
    }
}
