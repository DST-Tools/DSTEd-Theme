using System;

namespace DSTEd.UI.Theme {
    public class $NAME : Xceed.Wpf.AvalonDock.Themes.Theme {
        public override Uri GetResourceUri() {
            return new Uri("/DSTEd;component/UI/Theme/$NAME.xaml", UriKind.Relative);
        }
    }
}
