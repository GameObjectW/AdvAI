
using UnityEngine;
[CreateAssetMenu(menuName = "PluggableAI/State")]
public sealed class State : ScriptableObject
{

    public Action[] actions;
    public Transition[] Transitions;

    public Color SceneGizmoColor = Color.gray;

    public void UpdateState(StateController controller)
    {
        DoActions(controller);
        CheckTransition(controller);
    }

    private void DoActions(StateController controller)
    {
        for (int i = 0; i < actions.Length; i++)
        {
            actions[i].Act(controller);
        }
    }

    private void CheckTransition(StateController controller)
    {
        for (int i = 0; i < Transitions.Length; i++)
        {
            bool decisionSucceeded = Transitions[i].decision.Decide(controller);

            if (decisionSucceeded)
            {
                controller.TransitionToState(Transitions[i].TrueState);

            }
            else
            {
                controller.TransitionToState(Transitions[i].FalseState);
            }
        }
    }

}
