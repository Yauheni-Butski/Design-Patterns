# Design-Patterns
C# .NET solution with examples of design patterns. Based on book "Head first Design Patterns"

1. Observer

  1.1. Custom Observer
  
  1.2. Event observer
  
2. Strategy

---------------------------------------------
# 1. Observer
Implement example of source of news (NewsSubject). NewsSubject can publish news. Every news can have a users' comments.
And some of widgets (INewsWidgetObserver members) would like to be notified in the moment when new news has been published. Every news widget shows received news differently.

In current example we have follow observers:

1) **FullNewsWidget** - shows all of news attributes: header, main photo, text, date of creation.

2) **ShortCommentedNewsWidget** - shows only header of news and list of users' comments.

3) **ShortNewsWidget** - shows only header of news.

Also, current example illustrates *"Pull"* and *"Push"* NewsSubject working modes. All of the widgets received latest news, so all of them working in *Pull* mode.

**ShortCommentedNewsWidget** is working in *"Pull"* and *"Push"* modes. As all the other widgets he receives latest news, but after that he makes request for comments for this news.

**1.1 Custom Observer**

In Custom Observer example implementation was made without using delegates and events.

**1.2 Event Observer**

In Event Observer example implementation was made with delegate and events functionality in .NET.

# 2. Strategy

In this example we have different types of pokemons. Base abstract class *Pokemon.cs* have common parameters for all other pokemon types. Each type of pokemons, like *WaterPokemon.cs*, *FirePokemon.cs*, *ElectricPokemon.cs*, have different behaviour for *Attack()* and *Evolution()*.
But in Pokemon World we have many types of battles. And, for example in some case is better to choose big *WaterPokemon.cs*, but in some case small. For some battles it is better to choose only young and male pokemon. 
So, for any kind of pokemns we can have different rules for accept decision "Is this pokemon good for current battle or not?"
Pattern Strategy help to us change validation rules for any type of pokemons.
