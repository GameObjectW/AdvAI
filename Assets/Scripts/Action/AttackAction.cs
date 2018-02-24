
using UnityEngine;
[CreateAssetMenu(menuName = "PluggableAI/Action/Attack")]
public class AttackAction : Action {
    public override void Act(StateController controller)
    {
        Attack(controller);
    }

    private void Attack(StateController controller)
    {
        RaycastHit hit;

        Debug.DrawRay(controller.eyes.position, controller.eyes.forward * controller.enemystats.AttackRange, Color.yellow);


        if (Physics.SphereCast(controller.eyes.position, controller.enemystats.LookSphereCastRadius, controller.eyes.forward, out hit, controller.enemystats.AttackRange) && hit.collider.CompareTag("Player"))
        {
            if (controller.CheckIfCountDownElapsed(controller.enemystats.AttackRate))
            {
                controller.tankShooting.Fire(controller.enemystats.AttackForce, controller.enemystats.AttackRate);
            }
           
        }
    }
}
