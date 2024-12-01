using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

// ����������� ��������� (BallData) � �������

public class BallAuthoring : MonoBehaviour
{
    public float Speed;

    public float3 Direction;

    private class Baker : Baker<BallAuthoring>
    {
        public override void Bake (BallAuthoring authoring)
        {
            // Dynamic - ��������, ��� ��� ������ ����� ���������
            Entity entity = GetEntity(TransformUsageFlags.Dynamic);

            AddComponent(entity, new BallData
            {
                Speed = authoring.Speed,

                Direction = authoring.Direction
            });
        }
    }
}
