//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public GameStateDestroyedListenerComponent gameStateDestroyedListener { get { return (GameStateDestroyedListenerComponent)GetComponent(GameStateComponentsLookup.GameStateDestroyedListener); } }
    public bool hasGameStateDestroyedListener { get { return HasComponent(GameStateComponentsLookup.GameStateDestroyedListener); } }

    public void AddGameStateDestroyedListener(System.Collections.Generic.List<IGameStateDestroyedListener> newValue) {
        var index = GameStateComponentsLookup.GameStateDestroyedListener;
        var component = (GameStateDestroyedListenerComponent)CreateComponent(index, typeof(GameStateDestroyedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGameStateDestroyedListener(System.Collections.Generic.List<IGameStateDestroyedListener> newValue) {
        var index = GameStateComponentsLookup.GameStateDestroyedListener;
        var component = (GameStateDestroyedListenerComponent)CreateComponent(index, typeof(GameStateDestroyedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGameStateDestroyedListener() {
        RemoveComponent(GameStateComponentsLookup.GameStateDestroyedListener);
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
public sealed partial class GameStateMatcher {

    static Entitas.IMatcher<GameStateEntity> _matcherGameStateDestroyedListener;

    public static Entitas.IMatcher<GameStateEntity> GameStateDestroyedListener {
        get {
            if (_matcherGameStateDestroyedListener == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.GameStateDestroyedListener);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherGameStateDestroyedListener = matcher;
            }

            return _matcherGameStateDestroyedListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public void AddGameStateDestroyedListener(IGameStateDestroyedListener value) {
        var listeners = hasGameStateDestroyedListener
            ? gameStateDestroyedListener.value
            : new System.Collections.Generic.List<IGameStateDestroyedListener>();
        listeners.Add(value);
        ReplaceGameStateDestroyedListener(listeners);
    }

    public void RemoveGameStateDestroyedListener(IGameStateDestroyedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = gameStateDestroyedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveGameStateDestroyedListener();
        } else {
            ReplaceGameStateDestroyedListener(listeners);
        }
    }
}