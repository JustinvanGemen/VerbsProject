using UnityEngine;
using System.Collections;
//Joey vd Wijk
public class Pause : MonoBehaviour {

    private MenuScript menuScript;  //import menuscript as var.

	[SerializeField]
	private PlayerInputController playerInput;

    void Start()
    {
        menuScript = GetComponent<MenuScript>();  //instantiate menuscript.
    }
	
	// Update is called once per frame
	void Update () {
		if (playerInput.GetPauseInput) //wait till keycode p or escape gets pressed then do the Paused() function.
        {
			print ("auw");
            Paused();
        } 
	}

    void Paused()  //test what the timeScale is, if it is 0 go to the first function, if its 1 go to the 2nd.
    {
        if (Time.timeScale == 0) 
        {
            Time.timeScale = 1;  //set the timeScale to 1 (turn it back to normal speed)
            Canvas uiCanvas = menuScript.getCanvas(0); // make a new var for the ui canvas.
            menuScript.ScreenUpdate(uiCanvas); // turn the normal game UI back on.
        }
        else if (Time.timeScale == 1)
        {
            Time.timeScale = 0; //pause the game.
            Canvas pauseCanvas = menuScript.getCanvas(1); //make a new var for the pause menu.
            menuScript.ScreenUpdate(pauseCanvas); //enable the pause menu, disable the game UI.
        }
    }
}
