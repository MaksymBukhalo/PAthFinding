using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TriggerPlayerMask : MonoBehaviour
{
	private NavMeshAgent agent;

	// Start is called before the first frame update
	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == 4)
		{
			agent.speed -= 20;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.layer == 4)
		{
			agent.speed += 20;
		}
	}
}
