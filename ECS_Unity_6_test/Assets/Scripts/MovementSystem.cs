/*
 Система для передвижения сущности 
 */

using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public partial struct MovementSystem : ISystem
{
   public void OnUpdate(ref SystemState state)
    {
        foreach (var (data, transform) in SystemAPI.Query<RefRO<MoveData>, RefRW<LocalTransform>>())
        {
            float3 position = transform.ValueRO.Position;

            // Движение WASD
            position.x += data.ValueRO.Move.x * data.ValueRO.Speed * SystemAPI.Time.DeltaTime;

            position.z += data.ValueRO.Move.y * data.ValueRO.Speed * SystemAPI.Time.DeltaTime;

            transform.ValueRW.Position = position;            
        }
    }
}
