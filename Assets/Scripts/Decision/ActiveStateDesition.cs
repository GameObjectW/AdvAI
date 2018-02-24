
using UnityEngine;
[CreateAssetMenu(menuName = "PluggableAI/Decisions/ActiveState")]
public class ActiveStateDesition : Desition {
    public override bool Decide(StateController controller)
    {
       return isTargetActive(controller);
    }

    private bool isTargetActive(StateController controller)
    {
        return controller.chaseTarget.gameObject.activeSelf;
    }
}
