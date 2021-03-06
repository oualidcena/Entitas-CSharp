//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public UnityObjectComponent unityObject { get { return (UnityObjectComponent)GetComponent(GameComponentsLookup.UnityObject); } }
    public bool hasUnityObject { get { return HasComponent(GameComponentsLookup.UnityObject); } }

    public void AddUnityObject(UnityEngine.Object newUnityObject) {
        var index = GameComponentsLookup.UnityObject;
        var component = (UnityObjectComponent)CreateComponent(index, typeof(UnityObjectComponent));
        component.unityObject = newUnityObject;
        AddComponent(index, component);
    }

    public void ReplaceUnityObject(UnityEngine.Object newUnityObject) {
        var index = GameComponentsLookup.UnityObject;
        var component = (UnityObjectComponent)CreateComponent(index, typeof(UnityObjectComponent));
        component.unityObject = newUnityObject;
        ReplaceComponent(index, component);
    }

    public void RemoveUnityObject() {
        RemoveComponent(GameComponentsLookup.UnityObject);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherUnityObject;

    public static Entitas.IMatcher<GameEntity> UnityObject {
        get {
            if (_matcherUnityObject == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.UnityObject);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherUnityObject = matcher;
            }

            return _matcherUnityObject;
        }
    }
}
