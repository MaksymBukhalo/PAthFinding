using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathFinding : MonoBehaviour
{
    public Transform[] points;

    private NavMeshAgent _nav;
    private int _destPoint;

	private void Start()
	{
		_nav = gameObject.GetComponent<NavMeshAgent>();
	}

	private void FixedUpdate()
	{
		if (!_nav.pathPending && _nav.remainingDistance < 0.5f)
		{
			GoToNextPoint();
		}
	}

	private void GoToNextPoint()
	{
		if (points.Length == 0)
		{
			return;
		}
		_nav.destination = points[_destPoint].position;
		_destPoint = (_destPoint + 1) % points.Length;
	}
}
