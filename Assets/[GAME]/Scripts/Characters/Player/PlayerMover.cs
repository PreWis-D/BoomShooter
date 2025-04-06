using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover
{
    private readonly CharacterController _characterController;
    private readonly Transform _self;
    private readonly PlayerInput _input;
    private readonly float _baseSpeed;
    private readonly float _baseJumpHeight;

    private Vector3 _velocity;
    private Vector2 _moveInput;
    private float _bonusSpeed;

    private bool _isGrounded;
    public float _groundCheckDistance = 0.2f;
    public LayerMask groundMask;

    private bool _jumpInput;
    public float _bonusJumpHeight;
    public float _gravity = -9.81f;

    public PlayerMover(CharacterController characterControllerComponent, Transform self, PlayerInput input, PlayerProperties properties)
    {
        _characterController = characterControllerComponent;
        _self = self;
        _input = input;
        _baseSpeed = properties.BaseSpeed;
        _baseJumpHeight = properties.BaseJumpHeight;
    }

    public void Activate()
    {
        _input.Player.Enable();
    }

    public void Deactivate()
    {
        _input.Player.Disable();
    }

    public void SetBonusSpeed(float value)
    {
        _bonusSpeed = value;
    }

    public void SetBonusJumpHeight(float value)
    {
        _bonusJumpHeight = value;
    }

    public void Update()
    {
        Move();
    }

    void Move()
    {
        GroundHandle();
        MoveHandle();
        JumpHandle();
        GravityHandle();
    }

    private void GroundHandle()
    {
        _isGrounded = IsGroundedRayCast();

        if (_isGrounded && _velocity.y < 0)
            _velocity.y = -2f;
    }

    private void MoveHandle()
    {
        Vector3 move = _self.transform.right * _moveInput.x + _self.transform.forward * _moveInput.y;
        float speed = _baseSpeed + PercentageCalculator.ConvertToValue(_baseSpeed, _bonusSpeed);
        _characterController.Move(move * speed * Time.deltaTime);
    }

    private void JumpHandle()
    {
        if (_jumpInput && _isGrounded)
        {
            var jumpHeight = _baseJumpHeight + PercentageCalculator.ConvertToValue(_bonusJumpHeight, _bonusJumpHeight);
            _velocity.y = Mathf.Sqrt(jumpHeight * -2f * _gravity);
            _jumpInput = false;
        }
    }

    private void GravityHandle()
    {
        _velocity.y += _gravity * Time.deltaTime;
        _characterController.Move(_velocity * Time.deltaTime);
    }

    private bool IsGroundedRayCast()
    {
        float rayStartHeight = _characterController.center.y - _characterController.height / 2 + 0.1f;
        Vector3 rayStart = _self.position + Vector3.up * rayStartHeight;

        if (Physics.Raycast(rayStart, Vector3.down, _groundCheckDistance, groundMask))
            return true;

        return false;
    }

    #region Input events
    public void OnMove(InputAction.CallbackContext context)
    {
        _moveInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _jumpInput = true;
        }
    }
    #endregion
}