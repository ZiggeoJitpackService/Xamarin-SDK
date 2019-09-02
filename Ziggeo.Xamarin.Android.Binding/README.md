General info   
https://developer.xamarin.com/guides/android/advanced_topics/binding-a-java-library/binding-an-aar/
https://developer.xamarin.com/guides/android/advanced_topics/binding-a-java-library/troubleshooting-bindings/

Useful cases
1. Run gradle task `gradlew sdk:dependencies` to see a full list of dependencies
2. Make sure all dependencies are added to a binding project in references. Dependencies from NuGet is preferable before dependencies from jar/aar.
See the actual list if dependencies below
 - Gson (nuget)
 - ReactiveStreams (nuget)
 - RxJava2 Android (nuget)
 - Okhttp Logging interceptor (nuget)
 - Square okhttp3 (nuget)
 - Square okio (nuget)
 - Xamarin.Android.Arch.Core.Common (nuget)
 - Xamarin.Android.Arch.Core.Runtime (nuget)
 - Xamarin.Android.Arch.Lifecycle.Common (nuget)
 - Xamarin.Android.Arch.Lifecycle.Runtime (nuget)
 - Xamarin.Android.Support.Animated.Vector.Drawable (nuget)
 - Xamarin.Android.Support.Constraint.Layout (nuget)
 - Xamarin.Android.Support.Constraint.Layout.Solver (nuget)
 - Xamarin.Android.Support.Annotations (nuget)
 - Xamarin.Android.Support.Compat (nuget)
 - Xamarin.Android.Support.Core.UI (nuget)
 - Xamarin.Android.Support.Core.Utils (nuget)
 - Xamarin.Android.Support.Media.Compat (nuget)
 - Xamarin.Android.Support.v4 (nuget)
 - Xamarin.Android.Support.v7.AppCompat (nuget)
 - com.danikula:videocache (binding proj from gradle dependency)

3. After adding the dependencies there are can be binding conflicts due to C#/Java Generics binding problem. Common steps to resolve conflicts are
 - make sure there is a setter AND a getter for fields, not just a setter or just a getter nothod.
 - take a look at `Metadata.xml` and add config for resolving generic conflicts
4. It seems like binding for exoplayer or binding for aar at all does not share exported ids or styles, so
 - If you're getting error similar too `No resource found that matches the given name (at 'layout_constraintLeft_toRightOf' with value '@id/exo_play')`, make sure to mark all ids with plus sign.
 - If you're getting error similar too `No resource found that matches the given name (at 'style' with value '@style/ExoMediaButton.Play')`, make sure to duplicate missing styles from transitive aar in `styles.xml` of ziggeo sdk. Just create empty styles with the same names.
