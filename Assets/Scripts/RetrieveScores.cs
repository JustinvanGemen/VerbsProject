using UnityEngine;
using System.Collections;

public class RetrieveScores : MonoBehaviour {
    private string[] highScores;

    
    IEnumerator Start () {
        WWW dataInformation = new WWW("link");
        yield return dataInformation;
        string textData = dataInformation.text;
        highScores = textData.Split(";"[0]);
    }
}
