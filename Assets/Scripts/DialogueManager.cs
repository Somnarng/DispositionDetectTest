using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public List<DialogueData> dialogue;
    [SerializeField] private GameObject dialoguePrefab;
    [SerializeField] private GameObject dialogueHolder;

    private void Start()
    {
        foreach (DialogueData data in dialogue)
        {
            Initialize(data);
        }
    }//for each SO in the list, initialize it.
    private void Initialize(DialogueData data)
    {
        GameObject dialogueObj = Instantiate(dialoguePrefab, dialogueHolder.transform);
        dialogueObj.GetComponentInChildren<TMP_Text>().text = data.Information.text;
        var optionData = dialogueObj.GetComponent<DialogueOptionData>();
        optionData.data = data;
    }
}//assigns SO to script on prefab for later use.