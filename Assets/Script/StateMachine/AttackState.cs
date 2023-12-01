using UnityEngine;

public class AttackState : IState
{
    public void OnEnter(StateController controller)
    {
        // Implement state initialization logic for attack state here.
        Debug.Log("Entering Attack State");
    }

    public void UpdateState(StateController controller)
    {
        // Implement state-specific update logic for attack state here.
        Debug.Log("Attack State Update");
    }

    public void OnExit(StateController controller)
    {
        // Implement state exit logic for attack state here.
        Debug.Log("Exiting Attack State");
    }
}
