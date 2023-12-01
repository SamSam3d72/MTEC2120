using UnityEngine;

public class IdleState : IState
{
    public void OnEnter(StateController controller)
    {
        // Implement state initialization logic here.
        Debug.Log("Entering Idle State");
    }

    public void UpdateState(StateController controller)
    {
        // Implement state-specific update logic here.
        Debug.Log("Idle State Update");
    }

    public void OnExit(StateController controller)
    {
        // Implement state exit logic here.
        Debug.Log("Exiting Idle State");
    }
}
