using UnityEngine;

public class RunPlayerState : IPlayerState
{
    private readonly PlayerStateMachine _playerStateMachine;

    public RunPlayerState(PlayerStateMachine playerStateMachine)
    {
        _playerStateMachine = playerStateMachine;
    }

    public void Enter()
    {
        Debug.Log("Enter Run");
    }

    public void Exit()
    {
        Debug.Log("Exit Run");
    }
}
