using TweenPlayables.Editor;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;
using System.Collections.Generic;

namespace Redmond.QuectoLines.TweenPlayablesEx.Editor
{
    [CustomTimelineEditor(typeof(TweenLineControllerSplineTrack))]
    public class TweenLineControllerSplineTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => StylingEx.motionGraohicsColor;
        public override Texture2D TrackIcon => StylingEx.motionGraphicsIcon;
        public override string DefaultTrackName => "Tween Line Controller Spline Track";
    }

    [CustomTimelineEditor(typeof(TweenLineControllerSplineClip))]
    public class TweenLineControllerSplineClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween Line Controller Spline";
        public override Color ClipColor => StylingEx.motionGraohicsColor;
        public override Texture2D ClipIcon => StylingEx.motionGraphicsIcon;
    }

    [CustomPropertyDrawer(typeof(TweenLineControllerSplineBehaviour))]
    public class TweenLineControllerSplineBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "endA",
            "endB",
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
        
    }
}