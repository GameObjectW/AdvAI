
using UnityEngine;
[CreateAssetMenu(menuName = "PluggableAI/Decisions/ScaneDecision")]
public class ScaneDecision : Desition {
    public override bool Decide(StateController controller)
    {
        return Scan(controller);
    }

    private bool Scan(StateController controller)
    {
        controller.navMeshAgent.isStopped = true;
        controller.transform.Rotate(0,controller.enemystats.searchingTurnSpeed*Time.deltaTime,0);
        return controller.CheckIfCountDownElapsed(controller.enemystats.searchDuration);
    }
}
