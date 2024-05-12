using TweenPlayables.Editor;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;
using System.Collections.Generic;

namespace Redmond.QuectoLines.TweenPlayablesEx.Editor
{
    [CustomTimelineEditor(typeof(TweenLineControllerTwoPointsTrack))]
    public class TweenLineControllerTwoPointsTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => StylingEx.motionGraohicsColor;
        public override Texture2D TrackIcon => StylingEx.motionGraphicsIcon;
        public override string DefaultTrackName => "Tween Line Controller Two Points Track";
    }

    [CustomTimelineEditor(typeof(TweenLineControllerTwoPointsClip))]
    public class TweenLineControllerTwoPointsClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween Line Controller Two Points";
        public override Color ClipColor => StylingEx.motionGraohicsColor;
        public override Texture2D ClipIcon => StylingEx.motionGraphicsIcon;
    }

    [CustomPropertyDrawer(typeof(TweenLineControllerTwoPointsBehaviour))]
    public class TweenLineControllerTwoPointsBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "endA",
            "endB",
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}