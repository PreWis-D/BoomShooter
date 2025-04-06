using UnityEngine;

public class PlayerAnimator
{
    private readonly Animator _animatorComponent;
    private readonly PlayerMover _mover;

    public PlayerAnimator(Animator animatorComponent, PlayerMover mover)
    {
        _animatorComponent = animatorComponent;
        _mover = mover;
    }
}
