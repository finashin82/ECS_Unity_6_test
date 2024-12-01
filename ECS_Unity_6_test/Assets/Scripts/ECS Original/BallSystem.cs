using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;


public partial struct BallSystem : ISystem
{
    public void OnCreate(ref SystemState state)
    {
        // Проверяем, есть ли компонент BallData
        state.RequireForUpdate<BallData>();
    }

    public void OnUpdate (ref SystemState state)
    {
        BallJob job = new BallJob
        {
            DeltaTime = SystemAPI.Time.DeltaTime
        };

        job.ScheduleParallel();
    }

    public partial struct BallJob : IJobEntity
    {
        public float DeltaTime;

        public void Execute(ref BallData ball, ref LocalTransform transform)
        {
            transform = transform.Translate(ball.Direction * ball.Speed * DeltaTime);
        }
    }
}
