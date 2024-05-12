#if UNITY_EDITOR
using System.ComponentModel;
#endif
using TweenPlayables;
using UnityEngine;
using UnityEngine.Timeline;

namespace Redmond.QuectoLines.TweenPlayablesEx
{
    [TrackBindingType(typeof(SpriteRenderer))]
    [TrackClipType(typeof(TweenSpriteRendererSizeClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/2D/Ex/Tween Sprite Renderer Size Track")]
#endif
    public class TweenSpriteRendererSizeTrack : TweenAnimationTrack<SpriteRenderer, TweenSpriteRendererSizeMixerBehaviour, TweenSpriteRendererSizeBehaviour> { }
}