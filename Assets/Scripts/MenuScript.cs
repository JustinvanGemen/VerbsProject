using UnityEngine;
using System.Collections;
using UnityEngine.UI; //import to use UI (mostly to enable and disable canvasses)

//Joey vd Wijk
public class MenuScript : MonoBehaviour
{

    [SerializeField]
    private Canvas[] menus; //always put in the main menu first!
    public Canvas getCanvas(int i) //getter for a pause menu.
    {
            return menus[i];
    }


    void Awake()
    {
        for (int i = 0; i < menus.Length; i++) //for loop for the menus in the array.
        {
            if(menus[i] != menus[0])  //enable the main menu, the rest will be disabled at the start.
            {
                menus[i].enabled = false;
            }
            else
            {
                menus[i].enabled = true;
            }
        }
    }

    public void ScreenUpdate(Canvas menu) //function for enabling another canvas and disabling the others
    {
        for (int i = 0; i < menus.Length; i++) //same for loop
        {
            if (menus[i].name == menu.name)  //if the menu is the same as the menu requested enbable it, otherwise disable it.
            {
                menus[i].enabled = true;
            }
            else
            {
                menus[i].enabled = false;
            }
        }       
    }
}
