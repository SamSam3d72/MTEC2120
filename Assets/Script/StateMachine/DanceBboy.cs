using UnityEngine;

public class DanceBboy : IState
{
    public void OnEnter(StateController controller)
    {
        // Implement state initialization logic for the B-boy dance state here.
        Debug.Log("Entering B-boy Dance State");
        controller.animator.SetTrigger("DanceBboy");

    }

    public void UpdateState(StateController controller)
    {
        // Implement state-specific update logic for the B-boy dance state here.
        Debug.Log("B-boy Dance State Update");
    }

    public void OnExit(StateController controller)
    {
        // Implement state exit logic for the B-boy dance state here.
        Debug.Log("Exiting B-boy Dance State");
    }
}
