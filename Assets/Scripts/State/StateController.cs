using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(TankShooting))]
public class StateController : MonoBehaviour
{

    public State CurrentState;
    public State RemainState;

    public EnemyStats enemystats;
    public Transform eyes;

    [HideInInspector] public NavMeshAgent navMeshAgent;
    [HideInInspector] public TankShooting tankShooting;
    [HideInInspector] public int nextWayPoint;
    [HideInInspector] public Transform chaseTarget;
    [HideInInspector] public float stateTimeElapsed;
    public List<Transform> WayPointList;
    public bool aiActive;

    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        tankShooting = GetComponent<TankShooting>();
    }

    // Update is called once per frame
	void Update () {
	    if (!aiActive)
	    {
	        return;
	    }
        CurrentState.UpdateState(this);
	}

    private void OnDrawGizmos()
    {
        Gizmos.color = CurrentState.SceneGizmoColor;
        Gizmos.DrawWireSphere(eyes.position,enemystats.LookSphereCastRadius);
    }

    public void TransitionToState(State nextState)
    {
        if (nextState!=RemainState)
        {
            CurrentState = nextState;
            OnExitState();
        }
    }

    public bool CheckIfCountDownElapsed(float duration)
    {
        stateTimeElapsed += Time.deltaTime;
        return stateTimeElapsed >= duration;
    }

    private void OnExitState()
    {
        stateTimeElapsed = 0;
    }
}
