using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CZ1111
{
    struct Vector3D
    {
        public Vector3D(double x, double y, double z) { X = x; Y = y; Z = z; }

        public double X {  get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public readonly double Lenght => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));

        public void MultiplicationOnNum(double num)
        {
            X *= num; Y *= num; Z *= num;
        }
        public readonly double GeometricMultiplication(Vector3D vector, double angle_between) 
            => vector.Lenght * Lenght * Math.Cos(angle_between);

        public override readonly string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj?.ToString() == this.ToString();
        public override readonly int GetHashCode() => base.GetHashCode();

        public static Vector3D operator+(Vector3D lhs, Vector3D rhs) => new(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        public static Vector3D operator-(Vector3D lhs, Vector3D rhs) => new(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        public static double operator*(Vector3D lhs, Vector3D rhs) => lhs.X * rhs.X + lhs.Y * rhs.Y + lhs.Z * rhs.Z;

        public static Vector3D operator++(Vector3D vector) => new(vector.X++, vector.Y++, vector.Z++);
        public static Vector3D operator--(Vector3D vector) => new(vector.X--, vector.Y--, vector.Z--);

        public static bool operator ==(Vector3D lhs, Vector3D rhs) => lhs.Equals(rhs);
        public static bool operator !=(Vector3D lhs, Vector3D rhs) => !lhs.Equals(rhs);
    }
}
