using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Action/Patrol")]
public class PortalAction : Action {
    public override void Act(StateController controller)
    {
        Patrol(controller);
    }

    private void Patrol(StateController controller)
    {
        controller.navMeshAgent.SetDestination(controller.WayPointList[controller.nextWayPoint].position);
        controller.navMeshAgent.isStopped = false;
        if (controller.navMeshAgent.remainingDistance <= controller.navMeshAgent.stoppingDistance&&!controller.navMeshAgent.pathPending)
        {
            controller.nextWayPoint = (controller.nextWayPoint + 1) % controller.WayPointList.Count;

        }
        
    }
}
