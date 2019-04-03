using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "QuestionData")]
public class Question : ScriptableObject {

    public string question = "";
    public string[] answers = new string[4];
    
}
