using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Configs/GameConfig")]
public class GameConfig : ScriptableObject
{
    [field: SerializeField] public PlayerConfig PlayerConfig { get; private set; }
    //[field: SerializeField] public LevelConfig LevelConfig { get; private set; }
    //[field: SerializeField] public EnemyConfigsPack EnemyConfigsPack { get; private set; }
    //[field: SerializeField] public WeaponConfigsPack WeaponConfigsPack { get; private set; }
    //[field: SerializeField] public CollectableConfigsPack CollectableConfigsPack { get; private set; }
}