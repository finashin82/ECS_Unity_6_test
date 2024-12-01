/*
 Класс монобех нужен для добавления компонента со структурой к сущности.
Добавляется к объекту на сцене.
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
            // Dynamic - означает, что наш объект будет двигаться
            Entity entity = GetEntity(TransformUsageFlags.Dynamic);

            AddComponent(entity, new MoveData
            {
                Speed = authoring.Speed,

                Move = authoring.Move                
            });
        }
    }
}
