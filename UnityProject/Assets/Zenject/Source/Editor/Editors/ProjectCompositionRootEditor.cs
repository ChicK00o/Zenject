using System.Collections.Generic;
using System.Linq;
using Zenject;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using Object = UnityEngine.Object;
using ModestTree;

namespace Zenject
{
    [CustomEditor(typeof(ProjectCompositionRoot))]
    public class ProjectCompositionRootEditor : CompositionRootEditor
    {
    }
}
