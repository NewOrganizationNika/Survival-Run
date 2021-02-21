using System.Linq;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;

namespace Editor.MyEditors
{
    public static class BulkChildrenRenameMenuItemExtension
    {
        #region Rename Children

        [MenuItem("GameObject/Rename Children/Rename", false, 15)]
        private static void BulkRename(MenuCommand menuCommand)
        {
            if (!(menuCommand.context is GameObject parentGameObject)) return;
            var parent = parentGameObject.transform;
            for (var i = 0; i < parent.childCount; i++)
            {
                Undo.RecordObject(parent.GetChild(i).gameObject,
                                  $"Bulk Children Rename Method called on {parent.name} GameObject");
                parent.GetChild(i).name = i.ToString();
            }
        }

        [MenuItem("GameObject/Rename Children/Parent Prefix", false, 15)]
        private static void BulkRenameParentPrefix(MenuCommand menuCommand)
        {
            if (!(menuCommand.context is GameObject parentGameObject)) return;
            var parent = parentGameObject.transform;
            for (var i = 0; i < parent.childCount; i++)
            {
                Undo.RecordObject(parent.GetChild(i).gameObject,
                                  $"Bulk Children Rename with Parent Prefix Method called on {parent.name} GameObject");
                var name = parent.name;
                var matches = Regex.Matches(name, @"\s\(\d+\)").OfType<Match>().Select(e => e.Value).ToArray()
                                   .Aggregate("", (current, element) => current + element);
                var strWithoutCloneIndexing = matches.Length <= 0 ? name : name.Replace(matches, "");
                parent.GetChild(i).name = $"{strWithoutCloneIndexing} {i.ToString()}";
            }
        }

        [MenuItem("GameObject/Rename Children/Child Prefix", false, 15)]
        private static void BulkRenameChildPrefix(MenuCommand menuCommand)
        {
            if (!(menuCommand.context is GameObject parentGameObject)) return;
            var parent = parentGameObject.transform;
            for (var i = 0; i < parent.childCount; i++)
            {
                Undo.RecordObject(parent.GetChild(i).gameObject,
                                  $"Bulk Children Rename with Child Prefix Method called on {parent.name} GameObject");
                var name = parent.GetChild(i).name;
                var matches = Regex.Matches(name, @"\s\(\d+\)|\s\d+\b").OfType<Match>().Select(e => e.Value).ToArray()
                                   .Aggregate("", (current, element) => current + element);
                var strWithoutCloneIndexing = matches.Length <= 0 ? name : name.Replace(matches, "");
                parent.GetChild(i).name = $"{strWithoutCloneIndexing} {i.ToString()}";
            }
        }

        #endregion
    }
}