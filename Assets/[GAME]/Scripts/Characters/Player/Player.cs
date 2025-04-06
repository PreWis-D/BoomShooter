using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private CharacterController _characterControllerComponent;
    [SerializeField] private Animator _animatorComponent;

    private PlayerMover _mover;
    private PlayerAnimator _animator;

    public PlayerProperties Properties { get; private set; }

    public void Init(PlayerConfig config, PlayerInput input)
    {
        Properties = new PlayerProperties(config);
        
        _mover = new PlayerMover(_characterControllerComponent, transform, input, Properties);
        _animator = new PlayerAnimator(_animatorComponent, _mover);
    }

    public void Activate()
    {
        _mover.Activate();
    }

    public void Deactivate()
    {
        _mover.Deactivate();
    }

    private void Update()
    {
        _mover.Update();
    }
}
