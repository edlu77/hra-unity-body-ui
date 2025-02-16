using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MatrixExtensions
{
    

    public static Matrix4x4 BuildMatrix(float[] transformMatrix)
    {
        Matrix4x4 matrix = new Matrix4x4();
        matrix.SetColumn(0, new Vector4(transformMatrix[0], transformMatrix[1], transformMatrix[2], transformMatrix[3]));
        matrix.SetColumn(1, new Vector4(transformMatrix[4], transformMatrix[5], transformMatrix[6], transformMatrix[7]));
        matrix.SetColumn(2, new Vector4(transformMatrix[8], transformMatrix[9], transformMatrix[10], transformMatrix[11]));
        matrix.SetColumn(3, new Vector4(transformMatrix[12], transformMatrix[13], transformMatrix[14], transformMatrix[15]));

        return matrix;
    }

    public static Matrix4x4 GetMatrix(this Transform transform)
    {
        Matrix4x4 matrix = transform.localToWorldMatrix;

        return matrix;
    }
}