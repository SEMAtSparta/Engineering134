﻿
namespace SafariParkApp;

public struct Point3D
{
    public int x, y, z;

    public Point3D(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public int DistanceFromOrigin()
    {
        return (int)Math.Sqrt(x*x + y*y + z*z);
    }
}

