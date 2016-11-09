using UnityEngine;
using System.Collections;
using UnityEngine.UI; //import to use UI (mostly to enable and disable canvasses)

//Joey vd Wijk
public class CanvasSwitcher : MonoBehaviour
{
    [SerializeField]
	private GameObject[] menus; //always put in the main menu first!
	public GameObject getCanvas(int i) //getter for a pause menu. //docent vragen
    {


            return menus[i];
    }


    void Awake()
    {
        for (int i = 0; i < menus.Length; i++) //for loop for the menus in the array.
        {
            if(menus[i] != menus[0])  //enable the main menu, the rest will be disabled at the start.
            {
				menus[i].SetActive (false);
            }
            else
            {
				menus[i].SetActive (true);
            }
        }
    }

	public void ScreenUpdate(GameObject menu) //function for enabling another canvas and disabling the others
    {
        for (int i = 0; i < menus.Length; i++) //same for loop
        {
            if (menus[i].name == menu.name)  //if the menu is the same as the menu requested enbable it, otherwise disable it.
            {
				menus[i].SetActive (true);
            }
            else
            {
				menus[i].SetActive (false);
            }
        }       
    }
}
