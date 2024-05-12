using TweenPlayables.Editor;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;
using System.Collections.Generic;

namespace Redmond.QuectoLines.TweenPlayablesEx.Editor
{
    [CustomTimelineEditor(typeof(TweenLineMeshGeneratorTrack))]
    public class TweenLineMeshGeneratorTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => StylingEx.motionGraohicsColor;
        public override Texture2D TrackIcon => StylingEx.motionGraphicsIcon;
        public override string DefaultTrackName => "Tween Line Mesh Generator Track";
    }

    [CustomTimelineEditor(typeof(TweenLineMeshGeneratorClip))]
    public class TweenLineMeshGeneratorClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween Line Mesh Generator";
        public override Color ClipColor => StylingEx.motionGraohicsColor;
        public override Texture2D ClipIcon => StylingEx.motionGraphicsIcon;
    }

    [CustomPropertyDrawer(typeof(TweenLineMeshGeneratorBehaviour))]
    public class TweenLineMeshGeneratorBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "color",
            "thickness",
            "endCapDivisionCount",
            "endCapStretch",
            "cornerDivisionCount",
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}