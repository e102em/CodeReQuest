﻿// Copyright (c) 2011-2017 Silicon Studio Corp. All rights reserved. (https://www.co.jp)
// See LICENSE.md for full license information.
using Xenko.Core.Mathematics;
using Xenko.Engine;

namespace ThirdPersonPlatformer.Core
{
    public static class Utils
    {
        public static Vector3 LogicDirectionToWorldDirection(Vector2 logicDirection, CameraComponent camera, Vector3 upVector)
        {
            var inverseView = Matrix.Invert(camera.ViewMatrix);

            var forward = Vector3.Cross(upVector, inverseView.Right);
            forward.Normalize();

            var right = Vector3.Cross(forward, upVector);
            var worldDirection = forward * logicDirection.Y + right * logicDirection.X;
            worldDirection.Normalize();
            return worldDirection;
        }
    }
}
