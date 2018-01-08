using Player;
using UnityEngine;

namespace Menus
{
	public class Pause : MonoBehaviour {

		private CanvasSwitcher _canvasSwitcher;  //import menuscript.
		private int _enabledCanvas;
		private GameOver _gameDone;
		
		[SerializeField] private PlayerInputController _playerInput;

		private void Start()
		{
			Time.timeScale = 1;
			_canvasSwitcher = GetComponent<CanvasSwitcher>();  //instantiate menuscript.
		}

		private void Update ()
		{
			if (!_playerInput.GetPauseInput) return;
			if (_gameDone.GameDone) Paused();
		}

		public void Paused()  //test what the timeScale is, if it is 0 go to the first function, if its 1 go to the 2nd.
		{
			if (Time.timeScale == 0) 
			{
				Time.timeScale = 1;  //set the timeScale to 1 (turn it back to normal speed)
				_enabledCanvas = 0; // make a new var for the ui canvas.
				_canvasSwitcher.ScreenUpdate(_enabledCanvas); // turn the normal game UI back on.
				AudioListener.pause = false;
			}
			else if (Time.timeScale == 1)
			{
				Time.timeScale = 0; //pause the game.
				_enabledCanvas = 1; //make a new var for the pause menu.
				_canvasSwitcher.ScreenUpdate(_enabledCanvas); //enable the pause menu, disable the game UI.
				AudioListener.pause = true;
			}
		}
	}
}
