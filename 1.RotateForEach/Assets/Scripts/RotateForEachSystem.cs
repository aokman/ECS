using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public class RotateForEachSystem : SystemBase
{
    protected override void OnUpdate()
    {
        var deltaTime = Time.DeltaTime;

        Entities.WithName("RotateForEachSystem").ForEach((ref Rotation rotation, in RotateForEach rotationSpeed) =>
        {
            rotation.Value = math.mul(
                math.normalize(rotation.Value),
                quaternion.AxisAngle(math.up(), rotationSpeed.RadiansPerSecond * deltaTime));
        }).ScheduleParallel();
    }
}
