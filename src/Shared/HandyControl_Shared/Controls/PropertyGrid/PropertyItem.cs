﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace HandyControl.Controls
{
    public class PropertyItem : Control
    {
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            "Value", typeof(object), typeof(PropertyItem), new PropertyMetadata(default(object)));

        public object Value
        {
            get => GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        public static readonly DependencyProperty DisplayNameProperty = DependencyProperty.Register(
            "DisplayName", typeof(string), typeof(PropertyItem), new PropertyMetadata(default(string)));

        public string DisplayName
        {
            get => (string)GetValue(DisplayNameProperty);
            set => SetValue(DisplayNameProperty, value);
        }

        public static readonly DependencyProperty PropertyNameProperty = DependencyProperty.Register(
            "PropertyName", typeof(string), typeof(PropertyItem), new PropertyMetadata(default(string)));

        public string PropertyName
        {
            get => (string)GetValue(PropertyNameProperty);
            set => SetValue(PropertyNameProperty, value);
        }

        public static readonly DependencyProperty PropertyTypeNameProperty = DependencyProperty.Register(
            "PropertyTypeName", typeof(string), typeof(PropertyItem), new PropertyMetadata(default(string)));

        public string PropertyTypeName
        {
            get => (string)GetValue(PropertyTypeNameProperty);
            set => SetValue(PropertyTypeNameProperty, value);
        }

        public static readonly DependencyProperty DescriptionProperty = DependencyProperty.Register(
            "Description", typeof(string), typeof(PropertyItem), new PropertyMetadata(default(string)));

        public string Description
        {
            get => (string)GetValue(DescriptionProperty);
            set => SetValue(DescriptionProperty, value);
        }

        public static readonly DependencyProperty BrowsableProperty = DependencyProperty.Register(
            "Browsable", typeof(bool), typeof(PropertyItem), new PropertyMetadata(default(bool)));

        public bool Browsable
        {
            get => (bool)GetValue(BrowsableProperty);
            set => SetValue(BrowsableProperty, value);
        }

        public static readonly DependencyProperty IsReadOnlyProperty = DependencyProperty.Register(
            "IsReadOnly", typeof(bool), typeof(PropertyItem), new PropertyMetadata(default(bool)));

        public bool IsReadOnly
        {
            get => (bool)GetValue(IsReadOnlyProperty);
            set => SetValue(IsReadOnlyProperty, value);
        }

        public static readonly DependencyProperty DefaultValueProperty = DependencyProperty.Register(
            "DefaultValue", typeof(object), typeof(PropertyItem), new PropertyMetadata(default(object)));

        public object DefaultValue
        {
            get => GetValue(DefaultValueProperty);
            set => SetValue(DefaultValueProperty, value);
        }

        public static readonly DependencyProperty CategoryProperty = DependencyProperty.Register(
            "Category", typeof(string), typeof(PropertyItem), new PropertyMetadata(default(string)));

        public string Category
        {
            get => (string)GetValue(CategoryProperty);
            set => SetValue(CategoryProperty, value);
        }

        public static readonly DependencyProperty EditorProperty = DependencyProperty.Register(
            "Editor", typeof(PropertyEditorBase), typeof(PropertyItem), new PropertyMetadata(default(PropertyEditorBase)));

        public PropertyEditorBase Editor
        {
            get => (PropertyEditorBase)GetValue(EditorProperty);
            set => SetValue(EditorProperty, value);
        }

        public static readonly DependencyProperty EditorElementProperty = DependencyProperty.Register(
            "EditorElement", typeof(FrameworkElement), typeof(PropertyItem), new PropertyMetadata(default(FrameworkElement)));

        public FrameworkElement EditorElement
        {
            get => (FrameworkElement)GetValue(EditorElementProperty);
            set => SetValue(EditorElementProperty, value);
        }

        public static readonly DependencyProperty IsSelectedProperty = DependencyProperty.Register(
            "IsSelected", typeof(bool), typeof(PropertyItem), new PropertyMetadata(default(bool)));

        public bool IsSelected
        {
            get => (bool)GetValue(IsSelectedProperty);
            set => SetValue(IsSelectedProperty, value);
        }

        public static readonly DependencyProperty IsExpandedEnabledProperty = DependencyProperty.Register(
            "IsExpandedEnabled", typeof(bool), typeof(PropertyItem), new PropertyMetadata(default(bool)));

        public bool IsExpandedEnabled
        {
            get => (bool)GetValue(IsExpandedEnabledProperty);
            set => SetValue(IsExpandedEnabledProperty, value);
        }

        public static readonly DependencyProperty ConverterProperty = DependencyProperty.Register(
            "Converter", typeof(IValueConverter), typeof(PropertyItem), new PropertyMetadata(default(IValueConverter)));

        public IValueConverter Converter
        {
            get => (IValueConverter) GetValue(ConverterProperty);
            set => SetValue(ConverterProperty, value);
        }

        public virtual void InitElement()
        {
            if (Editor == null) return;
            EditorElement = Editor.CreateElement(this);
        }
    }
}