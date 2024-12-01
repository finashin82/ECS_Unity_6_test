using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public partial struct ShootSystem : ISystem
{ 
    public void OnUpdate(ref SystemState state)
    {
        //foreach (RefRW<ShootData> data in SystemAPI.Query<RefRW<ShootData>>())
        foreach (var (data, transform) in SystemAPI.Query<RefRO<ShootData>, RefRW<LocalTransform>>())
        {
            if (data.ValueRO.Shoot > 0f /*&& ballAuthoring1.ShootAction != null && ballAuthoring1.ShootAction is IAbility ability*/)
            {
                Debug.Log("+");
            }
        }
    }
}
