//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public CardTexture2DComponent cardTexture2D { get { return (CardTexture2DComponent)GetComponent(GameComponentsLookup.CardTexture2D); } }
    public bool hasCardTexture2D { get { return HasComponent(GameComponentsLookup.CardTexture2D); } }

    public void AddCardTexture2D(UnityEngine.Texture2D newValue) {
        var index = GameComponentsLookup.CardTexture2D;
        var component = (CardTexture2DComponent)CreateComponent(index, typeof(CardTexture2DComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCardTexture2D(UnityEngine.Texture2D newValue) {
        var index = GameComponentsLookup.CardTexture2D;
        var component = (CardTexture2DComponent)CreateComponent(index, typeof(CardTexture2DComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCardTexture2D() {
        RemoveComponent(GameComponentsLookup.CardTexture2D);
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

    static Entitas.IMatcher<GameEntity> _matcherCardTexture2D;

    public static Entitas.IMatcher<GameEntity> CardTexture2D {
        get {
            if (_matcherCardTexture2D == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CardTexture2D);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCardTexture2D = matcher;
            }

            return _matcherCardTexture2D;
        }
    }
}
