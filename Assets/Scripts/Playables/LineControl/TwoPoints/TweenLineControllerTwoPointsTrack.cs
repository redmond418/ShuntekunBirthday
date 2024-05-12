#if UNITY_EDITOR
using System.ComponentModel;
#endif
using TweenPlayables;
using UnityEngine.Timeline;

namespace Redmond.QuectoLines.TweenPlayablesEx
{
    [TrackBindingType(typeof(LineControllerTwoPoints))]
    [TrackClipType(typeof(TweenLineControllerTwoPointsClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/Quecto Lines/Tween Line Controller Two Points Track")]
#endif
    public class TweenLineControllerTwoPointsTrack : TweenAnimationTrack<LineControllerTwoPoints, TweenLineControllerTwoPointsMixerBehaviour, TweenLineControllerTwoPointsBehaviour> { }
}