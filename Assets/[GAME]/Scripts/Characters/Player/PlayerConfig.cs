using UnityEngine;

[CreateAssetMenu(fileName = "PlayerConfig", menuName = "Configs/Player/PlayerConfig")]
public class PlayerConfig : ScriptableObject
{
    [field: SerializeField] public float BaseHealt { get; private set; }
    [field: SerializeField] public float BaseArmor { get; private set; }
    [field: SerializeField] public float BaseSpeed { get; private set; }
    [field: SerializeField] public float BaseJumpHeight { get; private set; }
    [field: SerializeField] public float BaseDamage { get; private set; } // TODO: move damage to weapon properties
}
