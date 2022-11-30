using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MonsterCouch.Utilities
{
    public static class ScreenUtilities
    {
        public static bool IsWorldPosInsideScreenRange(Camera cam, Vector3 pos)
        {
            Vector3 screenPos = cam.WorldToScreenPoint(pos);
            return screenPos.x > 0f && screenPos.x < Screen.width && screenPos.y > 0f && screenPos.y < Screen.height;
        }
    }

}