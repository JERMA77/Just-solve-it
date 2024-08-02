using System;
using System.Collections.Generic;

public class PlayerStateMachine
{
    private Dictionary<Type, IPlayerState> _states;
    private IPlayerState _currentState;

    public PlayerStateMachine()
    {
        _states = new Dictionary<Type, IPlayerState>()
        {
            [typeof(RunPlayerState)] = new RunPlayerState(this),
            [typeof(JumpPlayerState)] = new JumpPlayerState(this),
        };
    }

    public void EnterIn<TState>() where TState : IPlayerState
    {
        if (_states.TryGetValue(typeof(TState), out IPlayerState state))
        {
            _currentState?.Exit();
            _currentState = state;
            _currentState.Enter();
        }
    }
}
