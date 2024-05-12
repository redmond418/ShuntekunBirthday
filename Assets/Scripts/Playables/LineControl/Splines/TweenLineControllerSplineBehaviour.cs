using TweenPlayables;
using System;

namespace Redmond.QuectoLines.TweenPlayablesEx
{
    [Serializable]
    public class TweenLineControllerSplineBehaviour : TweenAnimationBehaviour<LineControllerSpline>
    {
        public FloatTweenParameter endA;
        public FloatTweenParameter endB;

        public override void OnTweenInitialize(LineControllerSpline playerData)
        {
            endA.SetInitialValue(playerData, playerData.EndA);
            endB.SetInitialValue(playerData, playerData.EndB);
        }
    }

}