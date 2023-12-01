using UnityEngine;

public class DanceTwist : IState
{
    public void OnEnter(StateController controller)
    {
        // Implement state initialization logic for the twerk dance state here.
        Debug.Log("Entering Twerk Dance State");
        controller.animator.SetTrigger("DanceTwist");

    }

    public void UpdateState(StateController controller)
    {
        // Implement state-specific update logic for the twerk dance state here.
        Debug.Log("Twerk Dance State Update");
    }

    public void OnExit(StateController controller)
    {
        // Implement state exit logic for the twerk dance state here.
        Debug.Log("Exiting Twerk Dance State");
    }
}
