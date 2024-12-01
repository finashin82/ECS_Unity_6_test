/*
 ��������� ����������, ������� ����������� � ��������
 */
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

// ������ ��� ��������
public struct MoveData : IComponentData
{
    public float Speed;

    public float2 Move;    
}

// ������ ��� ���������
public struct BurstData : IComponentData
{
    public float BurstSpeed;

    public float2 Burst;
}

// ������ ��� ��������
public struct ShootData : IComponentData
{
    public float Shoot;

    //public MonoBehaviour ShootAction;
}
