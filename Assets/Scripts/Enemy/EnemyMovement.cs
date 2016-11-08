using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	
	private NavMeshAgent _navMeshAgent;
	private GameObject _playerObj;
	private bool canMove;

	public bool SwitchMovement
	{
		set
		{ canMove = value; }
	}

	// Use this for initialization
	void Awake () 
	{
		_navMeshAgent = GetComponent<NavMeshAgent> ();
		_playerObj = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {

		if(canMove)
		{
			_navMeshAgent.SetDestination (_playerObj.transform.position);
			transform.LookAt (_playerObj.transform.position);
		}

	}
}
