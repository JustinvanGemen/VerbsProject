using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	
	private NavMeshAgent navMeshAgent;
	private GameObject playerObj;
	private bool canMove = true;

	public bool SwitchMovement
	{
		set
		{ canMove = value; }
	}

	void Start () 
	{
		navMeshAgent = GetComponent<NavMeshAgent> ();
		playerObj = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update () {

		if(canMove)
		{
			navMeshAgent.SetDestination (playerObj.transform.position);
			transform.LookAt (playerObj.transform.position);
		}

	}
}
