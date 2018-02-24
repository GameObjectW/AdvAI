
using System;
using UnityEngine;
[CreateAssetMenu(menuName = "PluggableAI/EnemyStats")]
public class EnemyStats : ScriptableObject
{

    public float LookSphereCastRadius;
    public float lookRange;
    public int AttackForce;
    public float AttackRate;
    public float AttackRange;
    public float searchingTurnSpeed;
    public float searchDuration;
}
