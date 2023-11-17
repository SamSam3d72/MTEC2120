using UnityEngine;

public class EventManager : MonoBehaviour
{
    private void OnEnable()
    {
        Player.OnCubeHit += DestroyCube;
    }

    private void OnDisable()
    {
        Player.OnCubeHit -= DestroyCube;
    }

    private void DestroyCube(GameObject RHEF_RockDetailsB)
    {
        Destroy(RHEF_RockDetailsB);
    }
}
