using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashState : State
{
    protected D_DashState dashData;
    protected bool animationFinished;

    private Vector2 direction;

    public DashState(Entity entity, FiniteStateMachine stateMachine, string animName, D_DashState dashData) : base(entity, stateMachine, animName)
    {
        this.dashData = dashData;
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
        direction = entity.movement;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
    }

    public override void PhysicsUpdate()
    {

        base.PhysicsUpdate();
        Dash();
        Exit();
    }

    public virtual void TriggerAttack()
    {

    }
    public virtual void FinishAttack()
    {
        animationFinished = true;
    }

    public virtual void Dash()
    {
        if (Time.time-startTime >= dashData.DashTime){
            Debug.Log("Para");
            entity.rb.velocity = new Vector2(0, 0);
            entity.stateMachine.ChangeState(entity.movementState);
        }
        else
        {
            Debug.Log("sppeeeed");
            entity.rb.velocity = direction * 20;
        }
    }
}
