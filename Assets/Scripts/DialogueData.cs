using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class DialogueData : ScriptableObject
{
    [System.Serializable]
    public struct Info
    {
        public string text;
        public string NPC_Response;
        public int trustChange;
        public int composureChange;
    }//a struct with all info needed for each dialogue object
    [Header("Info")] public Info Information;
}
#if UNITY_EDITOR
[CustomEditor(typeof(DialogueData))]
public class DialogueEditor : Editor
    {
        [MenuItem("Assets/Dialogue", priority = 0)]
        public static void CreateDialogue()
        {var newQuest = CreateInstance<DialogueData>();
        ProjectWindowUtil.CreateAsset(newQuest, pathName: "dialogue.asset");
        }
    }//adds "Dialogue" scriptable object to the assets menu for easy access
#endif