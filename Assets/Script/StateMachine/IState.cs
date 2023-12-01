using UnityEngine;

public interface IState
{
    void OnEnter(StateController controller);
    void UpdateState(StateController controller);
    void OnExit(StateController controller);
}
