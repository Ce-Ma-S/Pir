﻿using Common.Components;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace Controls
{
    /// <summary>
    /// <see cref="IComponent"/> view.
    /// </summary>
    public class ComponentControl :
        SectionControl
    {
        public ComponentControl()
        {
            DefaultStyleKey = typeof(ComponentControl);
            SetBinding(NameProperty, new Binding()
            {
                Source = this,
                Path = new PropertyPath($"{nameof(Component)}.{nameof(IComponent.Id)}")
            });
            SetBinding(DataContextProperty, new Binding()
            {
                Source = this,
                Path = new PropertyPath(nameof(Component))
            });
            SetBinding(HeaderProperty, new Binding()
            {
                Source = this,
                Path = new PropertyPath($"{nameof(Component)}.{nameof(IComponent.Name)}")
            });
            SetBinding(HeaderContentProperty, new Binding()
            {
                Source = this,
                Path = new PropertyPath($"{nameof(Component)}")
            });
            SetBinding(DescriptionProperty, new Binding()
            {
                Source = this,
                Path = new PropertyPath($"{nameof(Component)}.{nameof(IComponent.Description)}")
            });
        }

        public static readonly DependencyProperty ComponentProperty = DependencyProperty.Register(
            nameof(Component), typeof(IComponent), typeof(ComponentControl), null);

        public IComponent Component
        {
            get { return (IComponent)GetValue(ComponentProperty); }
            set { SetValue(ComponentProperty, value); }
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            GetTemplateChild("Switch");
        }
    }
}
