using UnityEngine;

public class RunState : IState
{
    public void OnEnter(StateController controller)
    {
        // Implement state initialization logic for running state here.
        Debug.Log("Entering Run State");
    }

    public void UpdateState(StateController controller)
    {
        // Implement state-specific update logic for running state here.
        Debug.Log("Run State Update");
    }

    public void OnExit(StateController controller)
    {
        // Implement state exit logic for running state here.
        Debug.Log("Exiting Run State");
    }
}
