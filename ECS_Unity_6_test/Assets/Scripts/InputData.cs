/*
 Стурктура компонента, которая добавляется к сущности
 */
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

// Данные для движения
public struct MoveData : IComponentData
{
    public float Speed;

    public float2 Move;    
}

// Данные для ускорения
public struct BurstData : IComponentData
{
    public float BurstSpeed;

    public float2 Burst;
}

// Данные для выстрела
public struct ShootData : IComponentData
{
    public float Shoot;

    //public MonoBehaviour ShootAction;
}
