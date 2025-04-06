using UnityEngine;

public class PlayerProperties
{
    public float BaseHealth { get; private set; }
    public float BonusHealth { get; private set; }

    public float BaseArmor { get; private set; }
    public float BonusArmor { get; private set; }

    public float BaseDamage { get; private set; } // TODO: move logic damage to weapon system
    public float BonusDamage { get; private set; }

    public float BaseSpeed { get; private set; }
    public float BonusSpeed { get; private set; }

    public float BaseJumpHeight { get; private set; }
    public float BonusJumpHeight { get; private set; }


    public PlayerProperties(PlayerConfig config)
    {
        BaseHealth = config.BaseHealt;
        BaseArmor = config.BaseArmor;
        BaseDamage = config.BaseDamage;
        BaseSpeed = config.BaseSpeed;
        BaseJumpHeight = config.BaseJumpHeight;
    }
}
