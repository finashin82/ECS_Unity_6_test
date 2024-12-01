/*
 ����� ������� ����� ��� ���������� ���������� �� ���������� � ��������.
����������� � ������� �� �����.
 */

using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public class MoveDataAuthoring : MonoBehaviour
{
    public float Speed;

    public float2 Move;

    private class Baker : Baker<MoveDataAuthoring>
    {
        public override void Bake (MoveDataAuthoring authoring)
        {
            // Dynamic - ��������, ��� ��� ������ ����� ���������
            Entity entity = GetEntity(TransformUsageFlags.Dynamic);

            AddComponent(entity, new MoveData
            {
                Speed = authoring.Speed,

                Move = authoring.Move                
            });
        }
    }
}
