using UnityEngine;

public class DanceSilly : IState
{
    public void OnEnter(StateController controller)
    {
        // Implement state initialization logic for the silly dance state here.
        Debug.Log("Entering Silly Dance State");
    }

    public void UpdateState(StateController controller)
    {
        // Implement state-specific update logic for the silly dance state here.
        Debug.Log("Silly Dance State Update");
    }

    public void OnExit(StateController controller)
    {
        // Implement state exit logic for the silly dance state here.
        Debug.Log("Exiting Silly Dance State");
    }
}
