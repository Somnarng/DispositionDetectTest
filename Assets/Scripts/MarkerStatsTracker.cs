using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarkerStatsTracker : MonoBehaviour
{
    public Image marker;
    private int trustVal;
    private int composureVal;
    [SerializeField] private Animator DispAnim;

    private void OnEnable()
    {
        DialogueOptionData.ComposureChange += UpdateComposure;
        DialogueOptionData.TrustChange += UpdateTrust;
    }
    private void OnDisable()
    {
        DialogueOptionData.ComposureChange -= UpdateComposure;
        DialogueOptionData.TrustChange -= UpdateTrust;
    }
    private void UpdateTrust(int value)
    {
        trustVal += value;
        trustVal = Mathf.Clamp(trustVal, -20, 20);
        Debug.Log(trustVal);
        marker.rectTransform.anchoredPosition = new Vector3(trustVal * 5, marker.rectTransform.anchoredPosition.y,0);
        DispAnim.SetTrigger("DispoShow");
    }//is called on event trigger, adjusts markers position and plays animation.
    private void UpdateComposure(int value)
    {
        composureVal += value;
        composureVal = Mathf.Clamp(composureVal, -20, 20);
        marker.rectTransform.anchoredPosition = new Vector3 (marker.rectTransform.anchoredPosition.x, composureVal * 5,0);
        DispAnim.SetTrigger("DispoShow");
    }//is called on event trigger, adjusts markers position and plays animation.
}