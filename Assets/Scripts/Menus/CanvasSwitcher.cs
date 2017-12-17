using UnityEngine;

namespace Menus
{
    public class CanvasSwitcher : MonoBehaviour
    {
        [SerializeField] private GameObject[] _menus; //always put in the main menu first!
        public GameObject GetCanvas(int i) //getter for a pause menu.
        {
            return _menus[i];
        }

        private void Awake()
        {
            foreach (var t in _menus)
            {
                t.SetActive(t == _menus[0]); //enable the main menu, the rest will be disabled at the start.
            }
        }

        public void ScreenUpdate(int menu) //function for enabling another canvas and disabling the others
        {
            var nextCanvas = _menus[menu];
            foreach (var t in _menus)
            {
                if (t == null) return;
                var canvasCheck = t == nextCanvas;
                t.SetActive(canvasCheck);
            }
        }
    }
}
