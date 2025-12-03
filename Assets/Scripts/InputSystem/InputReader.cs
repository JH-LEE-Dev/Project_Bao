using UnityEngine;
using UnityEngine.InputSystem;
using System;

[CreateAssetMenu(menuName = "Game/Input/Input Reader")]
public class InputReader : ScriptableObject
{
    public event Action AttackEvent;
    public event Action SelectStartEvent;
    public event Action SelectEndEvent;
    public event Action<Vector2> RightClickEvent;

    private InputSystem_Actions actions;

    private void OnEnable()
    {
        if (actions == null)
        {
            actions = new InputSystem_Actions();

            actions.Player.Move.performed += OnMove;
            actions.Player.Move.canceled += OnMove;
            actions.Player.Attack.performed += OnAttack;
        }

        actions.Player.Enable();
    }

    private void OnDisable()
    {
        actions.Player.Disable();
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        RightClickEvent?.Invoke(context.ReadValue<Vector2>());
    }

    private void OnAttack(InputAction.CallbackContext context)
    {
        AttackEvent?.Invoke();
    }
}
