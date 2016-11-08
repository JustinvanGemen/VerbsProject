using UnityEngine;
using System.Collections;

public class RetrieveScores : MonoBehaviour {
    private string[] highScores;
	private WWW dataInformation;
	private string textData;
        
    IEnumerator Start () {
        dataInformation = new WWW("link");
        yield return dataInformation;
        textData = dataInformation.text;
        highScores = textData.Split(";"[0]);
    }
}
