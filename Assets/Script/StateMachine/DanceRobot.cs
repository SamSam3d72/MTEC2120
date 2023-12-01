using UnityEngine;

public class DanceRobot : IState
{
    public void OnEnter(StateController controller)
    {
        // Implement state initialization logic for the robot dance state here.
        Debug.Log("Entering Robot Dance State");
        controller.animator.SetTrigger("DanceRobot");

    }

    public void UpdateState(StateController controller)
    {
        // Implement state-specific update logic for the robot dance state here.
        Debug.Log("Robot Dance State Update");
    }

    public void OnExit(StateController controller)
    {
        // Implement state exit logic for the robot dance state here.
        Debug.Log("Exiting Robot Dance State");
    }
}
