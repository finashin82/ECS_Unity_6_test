/*
 Система для приданию ускорения сущности
 */
using Unity.Entities;
using UnityEngine;
using Unity.Mathematics;
using Unity.Transforms;

public partial struct BurstSystem : ISystem
{
    public void OnUpdate(ref SystemState state)
    {
        foreach (var (data, transform) in SystemAPI.Query<RefRO<BurstData>, RefRW<LocalTransform>>())
        {
            float3 position = transform.ValueRO.Position;           

            // Ускорение
            position.z += data.ValueRO.Burst.y * data.ValueRO.BurstSpeed * SystemAPI.Time.DeltaTime;

            transform.ValueRW.Position = position;
        }
    }
}
