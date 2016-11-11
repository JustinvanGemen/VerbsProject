using UnityEngine;
using System.Collections;
//Joey vd Wijk
public class Pause : MonoBehaviour {

	private CanvasSwitcher canvasSwitcher;  //import menuscript as var.
	private GameObject enabledCanvas;

	[SerializeField]
	private PlayerInputController playerInput;

    void Start()
    {
		canvasSwitcher = GetComponent<CanvasSwitcher>();  //instantiate menuscript.
    }
	
	// Update is called once per frame
	void Update () {
		if (playerInput.GetPauseInput) //wait till keycode p or escape gets pressed then do the Paused() function.
        {
            Paused();
        } 
	}

    public void Paused()  //test what the timeScale is, if it is 0 go to the first function, if its 1 go to the 2nd.
    {
        if (Time.timeScale == 0) 
        {
            Time.timeScale = 1;  //set the timeScale to 1 (turn it back to normal speed)
			enabledCanvas = canvasSwitcher.getCanvas(0); // make a new var for the ui canvas.
			canvasSwitcher.ScreenUpdate(enabledCanvas); // turn the normal game UI back on.
			AudioListener.pause = false;
        }
        else if (Time.timeScale == 1)
        {
            Time.timeScale = 0; //pause the game.
			enabledCanvas = canvasSwitcher.getCanvas(1); //make a new var for the pause menu.
			canvasSwitcher.ScreenUpdate(enabledCanvas); //enable the pause menu, disable the game UI.
			AudioListener.pause = true;
        }
    }
}
