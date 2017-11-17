using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
	public class EnemyMovement : MonoBehaviour {
	
		private NavMeshAgent _navMeshAgent;
		private GameObject _playerObj;
		private bool _canMove = true;

		public bool SwitchMovement
		{
			set
			{ _canMove = value; }
		}

		private void Start () 
		{
			_navMeshAgent = GetComponent<NavMeshAgent> ();
			_playerObj = GameObject.FindGameObjectWithTag ("Player");
		}

		private void Update () {
			if (!_canMove) return;
			_navMeshAgent.SetDestination (_playerObj.transform.position);
			transform.LookAt (_playerObj.transform.position);
		}
	}
}
