# SimpleECS
A Simple and easy to use C# Entity Component System.
Min C# Framework 4.7

### Features:
* No Dependencies, just build and drop in however you want
* No setup or boilerplate like marking components or code generators
* Archetype based = fast component iteration
* Very simple and easy to use queries

## Entities
An Entity is simply an ID associates a group of components together.
To create an entity use Entity.Create() with the components you want grouped.
```C#
Entity.Create("my entity", 3, 5f);    // creates a new entity with components
                                      // components added this way will trigger
                                      // the OnSetCallback event
```
Anything that can be put into a list can be a component.
Only one component of each type can be associated with an entity, however there's nothing
stopping you having a List<Component> as a component if you need more than one.
Setting more than one component of the same type will simply overwrite the old one.
The function can take up to 64 components, but entities themselves have 
no component limit.

Manipulating entities is pretty simple
```C#
if(entity)              // returns false if entity is destroyed or invalid
{}                      // shorthand for entity.IsValid()

entity.Get<int>() += 4; // gets the entity's component by ref value.
                        // throws an exception if the entity is invalid or
                        // the entity does not have the component
                        // since they are returned by ref, you can assign values directly

entity.Set(3)             // sets the entity's components to values.
      .Set("my entity");  // can be chained to set multiple components at once.
                          // if entity does not already contain the component it will be added
                          // setting a component will trigger the OnSetCallback component event 

if (enity.Has<int>())     // returns true if entity has component
{
  // do something
}

if (entity.TryGet(out int value)) // gets the component's value on entity, returns false if not found
{
    entity.Set(value + 4);        // Value types need to be set afterwards for changes to take place
}

entity.Remove<T>();   // removes the component on entity if found.
                      // if component was removed, will trigger on OnRemoveCallback event
                    
entity.Destroy();     // destroys the entity leaving it invalid
                      // all components on the entity will trigger their respective OnRemoveCallback events

```
## Component Callbacks
There are 2 component callbacks in SimpleECS. Below is a small example on how to use them.
```C#
class Callbacks // class implemnting the callbacks needs to be a non generic class
{
  // on set will be called anytime an entity sets a component
  // the method needs to be static with the parameters as (entity, ref component)
  [OnSetCallback]
  static void OnSetInt(Entity entity, ref int value)
  {
    Console.WriteLine($"{entity} set an int with a value of {value}");
  }
  
  // likewise on remove will be invoked anytime an entity removes a component.
  // when an entity is destroyed all components are removed.
  // if destroyed the entity will be invalid during the callback
  [OnRemoveCallback]
  static void OnRemoveInt(Entity entity, ref int value)
  {
    Console.WriteLine($"{entity} removed an int");  
  }
}

```


## Queries

Queries let you iterate over entities based on specified components.
You can specify up to 16 components to iterate over.
Queries cache their results and only update when new archetypes are created.

```C#
var query = new Query().Has<int>().Has<float>()       // Has() filters entities to those with components
                       .Not<string>().Not<double>();  // Not() filters for those that do not
                                                      // there's no limit to the amount of filters you can add
                                                      // infact the more specific the better

query.Foreach( (ref int int_value, ref float float_value) =>  // you then use the foreach function to update your components
{                                                             // components must be prefaced with the ref modifier
    int_value ++;                                             // you can use up to 16 components as parameters
    float_value = int_value * 100;                            // queries operate only on entities that match both the query 
}));                                                          // filter and contains all the foreach parameters


query.Foreach( (Entity entity, ref int value ) =>         // you can access the owner entity by putting it in the first position
{                                                         // without modifiers. You can then add any components you want to use
  Console.WriteLine($"{entity} value is {value}");        // afterwards
});

var all_entities = new Query();                       // a simple way to match against all entities is to make a query with no filters
all_entities.Foreach( entity => entity.Destroy());    // a simple way to delete all entities
```

Queries are already very fast, but for maximum performance or control
over iteration order, manual iteration is possible.
```C#
for(int i = 0; i < query.MatchingArchetypes.Count; ++ i) // getting the matching archetypes count will 
{                                                       // keep the query up-to-date
  var archetype = query.MatchingArchetypes[i];
    if (archetype.Entities.Count > 0 && archetype.TryGetArray(out int[] int_pool))  // try get array gets the raw component backing array
      for(int index = 0; index < archetype.Entities.Count; ++ index)    // int pool's count is the same as the entity count NOT the pool's length
        int_pool[index]++;
}
```

During Foreach structural changes made using Set(), Remove() and Destroy() are
cached and applied after iteration is complete. This is to prevent iterator
invalidation. You can still create entities during foreach loops though as these
do not affect archetype structures.

```C#
var entity = Entity.Create("my entity", 3);
entity.Remove<string>();
entity.Has<string>();       // this will return false

query.Foreach((Entity entity, ref int int_val) =>
{
  entity.Remove<int>();     // since this is a structural change and we are in 
                            // the middle of iterating, this operation will be cached
  
  entity.Has<int>();        // since Remove() was cached, this will still return true
  
  entity.Set("my entity");  // Since this was removed before the query, this is a 
                            // structural operation and will also be cached
  
  entity.Has<string>();     // so this will still false
});
// now all structural changes are applied since we are done iterating entities

entity.Has<string>();   // this will now return true
entity.Has<int>();      // and this will now return false
```
## Archetype
Entites are stored in archetypes. Archetypes are simply a container of arrays that
store entities and their components. All arrays are contiguous and of a single type.
i.e all entities are stored together, each component type is stored together.
The entity in index 1 of the entity array owns the components in index 1 of each component
array. Queries don't match against single entities but actually archetypes since all
entities within an archetype has the same component types by definition.
```C#
var entity = Entity.Create(3);

if (entity.TryGetArchetype(out var archetype))  // gets archetype that the entity belongs to
{                                               // will return false if entity is invalid
  if (archetype)  // use to check if archetype is valid
  {               // valid entities will always have valid archetypes
    //...
  }
  
  archetype.CreateEntity(); // creates an entity with a signature matching the archetype's
                            // entities created this way will have components with default values
                            // i.e. ref types as null and value types as 0
                            // Since the components were not set explicitly they will not trigger OnSetCallback
                            // This is the most performant way to create an entity

  archetype.Foreach((ref int value) => value ++); // you can iterate over components in an
                                                  // archetype just like you can with queries
                                                  
  foreach(var entity in archetype.Entities) // you can get the entities in an archetype with
  {                                         // with the Entities property
    Console.WriteLine(entity);
  }
                                                  
  if (archetype.TryGetArray(out int[] int_values))      // you can get the component arrays using TryGetArray()
  {                                                     // returns false if entities don't have component
    for(int i = 0; i < archetype.Entities.Count; ++ i)  // the component count is not the array's length
    {                                                   // but the archetype's entity count. Be sure not to
      int_values[i] ++;                                 // use the wrong values
    }
  }
}

```

## World
The world static class is what manages all the underlying archetypes and their entities. 
Normally you won't need to do much with this class but there are a couple of useful features.
```C#
World.AllowStructuralChanges = true;  // set to false to start caching structural changes
                                      // changes will be appiled when set back to true.
                                      // query.Foreach() internally sets this to false before starting
                                      // the query and true once complete
                                      
World.ResizeBackingArrays();          // if a large amount of entities and components were recently deleted, 
                                      // use this to resize the archetype backing arrays. This can be
                                      // followed up with System.GC.Collect() to reclaim memory.

World.RemoveEmptyArchetypes();        // Use to remove archetypes that have no entities. Useful when
                                      // changing scenes in game engines.
                                      // Any archetypes removed in this process will be invalid
```
