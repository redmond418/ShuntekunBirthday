#if UNITY_EDITOR
using System.ComponentModel;
#endif
using TweenPlayables;
using UnityEngine.Timeline;

namespace Redmond.QuectoLines.TweenPlayablesEx
{
    [TrackBindingType(typeof(LineControllerSpline))]
    [TrackClipType(typeof(TweenLineControllerSplineClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/Quecto Lines/Tween Line Controller Splines Track")]
#endif
    public class TweenLineControllerSplineTrack : TweenAnimationTrack<LineControllerSpline, TweenLineControllerSplineMixerBehaviour, TweenLineControllerSplineBehaviour> { }
}