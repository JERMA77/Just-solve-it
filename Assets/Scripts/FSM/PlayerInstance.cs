using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstance : MonoBehaviour
{
    private PlayerStateMachine _playerStateMachine;
    private void Awake()
    {
        _playerStateMachine = new PlayerStateMachine();

        _playerStateMachine.EnterIn<RunPlayerState>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerStateMachine.EnterIn<JumpPlayerState>();
        }
    }
}
