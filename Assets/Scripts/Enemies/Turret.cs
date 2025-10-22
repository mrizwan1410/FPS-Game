using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] Transform turretHead;
    [SerializeField] Transform playerTargetPoint;

    void Update()
    {
        turretHead.LookAt(playerTargetPoint);
    }
}
