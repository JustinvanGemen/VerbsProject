using UnityEngine;

namespace Player
{
    public class TargetFollow : MonoBehaviour
    {

        public Transform Target;

        private Vector3 _offset;

        private void Start()
        {
            _offset = transform.position - Target.position;
        }


        private void LateUpdate()
        {
            transform.position = Target.position + _offset;
        }
    }
}
