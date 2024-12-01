/*
 —истема дл€ ввода значений с InputSystem_Action
 */
using Unity.Entities;
using UnityEngine;

public partial class InputSystem : SystemBase
{
    private InputSystem_Actions inputActions;

    protected override void OnCreate()
    {
        inputActions = new InputSystem_Actions();

        inputActions.Enable();
    }

    protected override void OnUpdate()
    {
        // ¬вод данных дл€ движени€ объекта
        foreach (RefRW<MoveData> data in SystemAPI.Query<RefRW<MoveData>>())
        {
            data.ValueRW.Move = inputActions.Player.Move.ReadValue<Vector2>();            
        }

        // ¬вод данных дл€ ускорени€
        foreach (RefRW<BurstData> data in SystemAPI.Query<RefRW<BurstData>>())
        {
            data.ValueRW.Burst = inputActions.Player.Sprint.ReadValue<float>();
        }

        // ¬вод данных дл€ выстрела
        foreach (RefRW<ShootData> data in SystemAPI.Query<RefRW<ShootData>>())
        {
            data.ValueRW.Shoot = inputActions.Player.Attack.ReadValue<float>();
        }
    }
}
