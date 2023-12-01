using UnityEngine;

public class DanceHipHop : IState
{
    public void OnEnter(StateController controller)
    {
        // Implement state initialization logic for the hip-hop dance state here.
        Debug.Log("Entering Hip-Hop Dance State");
        controller.animator.SetTrigger("DanceHipHop");

    }

    public void UpdateState(StateController controller)
    {
        // Implement state-specific update logic for the hip-hop dance state here.
        Debug.Log("Hip-Hop Dance State Update");
    }

    public void OnExit(StateController controller)
    {
        // Implement state exit logic for the hip-hop dance state here.
        Debug.Log("Exiting Hip-Hop Dance State");
    }
}
