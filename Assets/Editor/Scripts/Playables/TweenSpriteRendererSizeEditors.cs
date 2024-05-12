using TweenPlayables.Editor;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;
using System.Collections.Generic;

namespace Redmond.QuectoLines.TweenPlayablesEx.Editor
{
    [CustomTimelineEditor(typeof(TweenSpriteRendererSizeTrack))]
    public class TweenSpriteRendererSizeTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styles.RendererColor;
        public override Texture2D TrackIcon => Styles.SpriteRendererIcon;
        public override string DefaultTrackName => "Tween Sprite Renderer Size Track";
    }

    [CustomTimelineEditor(typeof(TweenSpriteRendererSizeClip))]
    public class TweenSpriteRendererSizeClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween Sprite Renderer Size";
        public override Color ClipColor => Styles.RendererColor;
        public override Texture2D ClipIcon => Styles.SpriteRendererIcon;
    }

    [CustomPropertyDrawer(typeof(TweenSpriteRendererSizeBehaviour))]
    public class TweenSpriteRendererSizeBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "size",
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}