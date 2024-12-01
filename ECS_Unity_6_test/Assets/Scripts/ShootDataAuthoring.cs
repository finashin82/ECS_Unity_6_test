/*
 ����� ������� ����� ��� ���������� ���������� �� ���������� � ��������.
����������� � ������� �� �����.
 */

using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public class ShootDataAuthoring : MonoBehaviour
{
    public MonoBehaviour ShootAction;

    private class Baker : Baker<ShootDataAuthoring>
    {
        public override void Bake (ShootDataAuthoring authoring)
        {
            // Dynamic - ��������, ��� ��� ������ ����� ���������
            Entity entity = GetEntity(TransformUsageFlags.Dynamic);

            AddComponent(entity, new ShootData
            {
                //ShootAction = authoring.ShootAction
            });
        }
    }
}
