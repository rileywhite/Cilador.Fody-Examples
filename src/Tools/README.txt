Unless you've updated your FodyWeavers.xml to behave differently, then this is the location
where Fody will look to find assemblies containing custom Mixin implementation types, so copy
those here, perhaps in a post-build event. You will also need to put your Mixin Definition
interface assemblies here. A post-build event is a good way to do this, as well.

See the example post-build events for MyMixinDefinitions and MyMixins projects to see how
you might do this.