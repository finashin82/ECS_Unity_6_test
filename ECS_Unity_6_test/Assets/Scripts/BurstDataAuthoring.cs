/*
 ����� ������� ����� ��� ���������� ���������� �� ���������� � ��������.
����������� � ������� �� �����.
 */

using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public class BurstDataAuthoring : MonoBehaviour
{
    public float BurstSpeed;

    //public float2 Burst;

    //public MonoBehaviour ShootAction;

    //public float Shoot;

    private class Baker : Baker<BurstDataAuthoring>
    {
        public override void Bake (BurstDataAuthoring authoring)
        {
            // Dynamic - ��������, ��� ��� ������ ����� ���������
            Entity entity = GetEntity(TransformUsageFlags.Dynamic);

            AddComponent(entity, new BurstData 
            { 
                //Burst = authoring.Burst,

                BurstSpeed = authoring.BurstSpeed
            });

            //AddComponent(entity, new ShootData
            //{
            //    //Shoot = authoring.Shoot
            //});
        }
    }
}
