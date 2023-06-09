using F2Rename;
using Il2Cpp;
using Il2CppInterop.Runtime;
using Il2CppRLD;
using MelonLoader;
using UnityEngine;

[assembly: MelonGame()]
[assembly: MelonInfo(typeof(F2Mod), "F2 Rename", "1.0.0", "GoldenretriverYT")]

namespace F2Rename {
    public class F2Mod : MelonMod {
        private string name = "";
        private bool inputEnabled = false;
        private bool justOpened = false;
        private Instance instance;


        public override void OnUpdate() {
            base.OnUpdate();

            if (Input.GetKeyDown(KeyCode.F2)) {
                var instances = MonoSingleton<RTObjectSelection>.Get.SelectedObjects;
                if (instances.Count != 1) return;

                instance = instances[0].GetComponent<Instance>();
                name = instance.Name;
                inputEnabled = true;
                justOpened = true;
            }
        }

        public override void OnGUI() {
            var style = new GUIStyle();
            style.fontSize = 72;
            style.alignment = TextAnchor.MiddleCenter;

            if (inputEnabled) {
                GUI.SetNextControlName("sus");
                name = GUI.TextArea(new Rect(0, 0, Screen.width, Screen.height), name, style);
                GUI.FocusControl("sus");

                if (justOpened) {
                    var te = GUIUtility.GetStateObject(Il2CppType.Of<TextEditor>(), GUIUtility.keyboardControl)
                        .TryCast<TextEditor>(); // We cant directly cast in Il2Cpp MelonLoader mods
                    if (te == null) {
                        LoggerInstance.Error("oof!");
                    }

                    te.cursorIndex = 0; // i cant get this shit to work rn who gives a fuck
                    te.selectIndex = te.text.Length;
                    justOpened = false;
                }

                if (name.Contains("\n")) {
                    name = name.ReplaceLineEndings("");

                    instance.Name = name;
                    inputEnabled = false;

                    // to hopefully fix the non-updating names in treeview
                    CreatorController.singleton.TreeView.Collapse(instance.Parent);
                    CreatorController.singleton.TreeView.Expand(instance.Parent);
                }
            }
        }
    }
}