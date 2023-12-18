namespace SkyBots.Api.Mathematics;

public readonly struct View
{
    public float Yaw { get; }
    public float Pitch { get; }

    public Vector3<float> Direction
    {
        get
        {
            var xz = Math.Cos(Mathe.ToRadians(Pitch));
            var vector = new Vector3<float>(
                (float)-Math.Sin(Mathe.ToRadians(Pitch)),
                (float)(-xz * Math.Sin(Mathe.ToRadians(Yaw))),
                (float)(xz * Math.Cos(Mathe.ToRadians(Yaw))));
            return vector;
        }
    }

    public View(float yaw, float pitch)
    {
        Yaw = yaw;
        Pitch = pitch;
    }

    public View(Vector3<float> vector)
    {
        float yaw = 0;
        float pitch;
        var x = vector.X;
        var z = vector.Z;
        if (x == 0.0 && z == 0.0)
            pitch = vector.Y > 0.0 ? -90 : 90;
        else
        {
            var theta = (float)Math.Atan2(-x, z);
            yaw = Mathe.ToDegrees((theta + 6.283185307179586) % 6.283185307179586);
            var xz = Math.Sqrt(x * x + z * z);
            pitch = Mathe.ToDegrees(Math.Atan(-vector.Y / xz));
        }

        Yaw = yaw;
        Pitch = pitch;
    }

    public override string ToString() => $"yaw: {Yaw}; pitch: {Pitch}";

    public bool Equals(View other) => Yaw.Equals(other.Yaw) && Pitch.Equals(other.Pitch);

    public override bool Equals(object? obj) => obj is View other && Equals(other);

    public override int GetHashCode() => HashCode.Combine(Yaw, Pitch);

    public static bool operator ==(View left, View right) =>
        left.Pitch.Equals(right.Pitch) && left.Yaw.Equals(right.Yaw);

    public static bool operator !=(View left, View right) => !(left == right);
}