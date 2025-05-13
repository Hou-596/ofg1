using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAirState : PlayerState
{
    public PlayerAirState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if (player.IsWallDetected())
        {
            //stateMachine.ChangeState(player.wallSlide);
        }

        if (xInput != 0)
        {
            //可以调整空中水平运动速度
            player.SetVelocity(player.moveSpeed * xInput, rb.velocity.y);
        }

        if (yInput > 0)
        {
            player.SetVelocity(rb.velocity.x, rb.velocity.y * 0.7f);
        }

        if (player.IsGroundDetected())
        {
            player.SetVelocity(0, rb.velocity.y);
            stateMachine.ChangeState(player.idleState);
        }
    }
}
