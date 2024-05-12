#if UNITY_EDITOR
using System.ComponentModel;
#endif
using TweenPlayables;
using UnityEngine.Timeline;

namespace Redmond.QuectoLines.TweenPlayablesEx
{
    [TrackBindingType(typeof(LineMeshGenerator))]
    [TrackClipType(typeof(TweenLineMeshGeneratorClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/Quecto Lines/Tween Line Mesh Generator Track")]
#endif
    public class TweenLineMeshGeneratorTrack : TweenAnimationTrack<LineMeshGenerator, TweenLineMeshGeneratorMixerBehaviour, TweenLineMeshGeneratorBehaviour> { }
}