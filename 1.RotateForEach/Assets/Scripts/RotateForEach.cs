using Unity.Entities;

[GenerateAuthoringComponent]
public struct RotateForEach : IComponentData
{
    public float RadiansPerSecond;
}