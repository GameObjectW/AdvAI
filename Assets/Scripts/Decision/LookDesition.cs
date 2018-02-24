
using UnityEngine;
[CreateAssetMenu(menuName = "PluggableAI/Action/LookDesition")]
public class LookDesition : Desition {
    public override bool Decide(StateController controller)
    {
        return Look(controller);
    }

    private bool Look(StateController controller)
    {
        RaycastHit hit;

        Debug.DrawRay(controller.eyes.position,controller.eyes.forward*controller.enemystats.lookRange,Color.red);


        if (Physics.SphereCast(controller.eyes.position,controller.enemystats.LookSphereCastRadius,controller.eyes.forward,out hit,controller.enemystats.lookRange)&&hit.collider.CompareTag("Player"))
        {
            controller.chaseTarget = hit.transform;
            return true;
        }
        return false;
    }
}
