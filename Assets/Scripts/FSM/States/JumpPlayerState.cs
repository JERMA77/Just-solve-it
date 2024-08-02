using UnityEngine;

public class JumpPlayerState : IPlayerState
{
    private readonly PlayerStateMachine _playerStateMachine;

    public JumpPlayerState(PlayerStateMachine playerStateMachine)
    {
        _playerStateMachine = playerStateMachine;
    }

    public void Enter()
    {
        Debug.Log("Enter Jump");
    }

    public void Exit()
    {
        Debug.Log("Exit Jump");
    }
}
