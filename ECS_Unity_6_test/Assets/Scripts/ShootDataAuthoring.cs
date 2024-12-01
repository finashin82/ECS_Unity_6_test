/*
 Класс монобех нужен для добавления компонента со структурой к сущности.
Добавляется к объекту на сцене.
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
            // Dynamic - означает, что наш объект будет двигаться
            Entity entity = GetEntity(TransformUsageFlags.Dynamic);

            AddComponent(entity, new ShootData
            {
                //ShootAction = authoring.ShootAction
            });
        }
    }
}
