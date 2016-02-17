//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public JaggedArrayComponent jaggedArray { get { return (JaggedArrayComponent)GetComponent(ComponentIds.JaggedArray); } }

        public bool hasJaggedArray { get { return HasComponent(ComponentIds.JaggedArray); } }

        public Entity AddJaggedArray(string[][] newJaggedArray) {
            var componentPool = GetComponentPool(ComponentIds.JaggedArray);
            var component = (JaggedArrayComponent)(componentPool.Count > 0 ? componentPool.Pop() : new JaggedArrayComponent());
            component.jaggedArray = newJaggedArray;
            return AddComponent(ComponentIds.JaggedArray, component);
        }

        public Entity ReplaceJaggedArray(string[][] newJaggedArray) {
            var componentPool = GetComponentPool(ComponentIds.JaggedArray);
            var component = (JaggedArrayComponent)(componentPool.Count > 0 ? componentPool.Pop() : new JaggedArrayComponent());
            component.jaggedArray = newJaggedArray;
            ReplaceComponent(ComponentIds.JaggedArray, component);
            return this;
        }

        public Entity RemoveJaggedArray() {
            return RemoveComponent(ComponentIds.JaggedArray);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherJaggedArray;

        public static IMatcher JaggedArray {
            get {
                if (_matcherJaggedArray == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.JaggedArray);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherJaggedArray = matcher;
                }

                return _matcherJaggedArray;
            }
        }
    }
}
