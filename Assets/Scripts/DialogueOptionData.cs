using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueOptionData : MonoBehaviour
{
    public DialogueData data;
    public GameObject npcResponsePanel;
    public static event Action<int> TrustChange;
    public static event Action<int> ComposureChange;
    private void OnEnable()
    {
        npcResponsePanel = GameObject.FindGameObjectWithTag("Response");
    }
    public void Selection()
    {
        npcResponsePanel.GetComponent<CanvasGroup>().interactable = true;
        npcResponsePanel.GetComponent<CanvasGroup>().blocksRaycasts = true;
        npcResponsePanel.GetComponent<CanvasGroup>().alpha = 1;
        npcResponsePanel.GetComponentInChildren<TMP_Text>().text = data.Information.NPC_Response;
        TrustChange.Invoke(data.Information.trustChange);
        ComposureChange.Invoke(data.Information.composureChange);
        //Destroy(gameObject);
    }//shows the NPC response, invokes game events for each change, removes this option from the selectable options
}