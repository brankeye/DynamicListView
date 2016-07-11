using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Playground.ViewModels.Controls
{
    public partial class ExtendedPicker : Picker
    {
        public ExtendedPicker()
        {
            base.SelectedIndexChanged += OnSelectedIndexChanged;
        }

        public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create("SelectedItem", typeof(object), typeof(ExtendedPicker), null, BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(ExtendedPicker.OnSelectedItemChanged), null, null, null);
        public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create("ItemsSource", typeof(IEnumerable<dynamic>), typeof(ExtendedPicker), null, BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(ExtendedPicker.OnItemsSourceChanged), null, null, null);
        public static readonly BindableProperty DisplayPropertyProperty = BindableProperty.Create("DisplayProperty", typeof(string), typeof(ExtendedPicker), null, BindingMode.OneWay, null, new BindableProperty.BindingPropertyChangedDelegate(ExtendedPicker.OnDisplayPropertyChanged), null, null, null);

        public IList<dynamic> ItemsSource
        {
            get { return (IList<dynamic>)base.GetValue(ExtendedPicker.ItemsSourceProperty); }
            set { base.SetValue(ExtendedPicker.ItemsSourceProperty, value); }
        }

        public object SelectedItem
        {
            get { return base.GetValue(ExtendedPicker.SelectedItemProperty); }
            set
            {
                base.SetValue(ExtendedPicker.SelectedItemProperty, value);
                if (ItemsSource.Contains(SelectedItem))
                {
                    SelectedIndex = ItemsSource.IndexOf(SelectedItem);
                }
                else
                {
                    SelectedIndex = -1;
                }
            }
        }

        public string DisplayProperty
        {
            get { return (string)base.GetValue(ExtendedPicker.DisplayPropertyProperty); }
            set { base.SetValue(ExtendedPicker.DisplayPropertyProperty, value); }
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedItem = ItemsSource[SelectedIndex];
        }


        private static void OnSelectedItemChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ExtendedPicker picker = (ExtendedPicker)bindable;
            picker.SelectedItem = newValue;
            if (picker.ItemsSource != null && picker.SelectedItem != null)
            {
                int count = 0;
                foreach (object obj in picker.ItemsSource)
                {
                    if (obj == picker.SelectedItem)
                    {
                        picker.SelectedIndex = count;
                        break;
                    }
                    count++;
                }
            }
        }

        private static void OnDisplayPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ExtendedPicker picker = (ExtendedPicker)bindable;
            picker.DisplayProperty = (string)newValue;
            loadItemsAndSetSelected(bindable);

        }
        private static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ExtendedPicker picker = (ExtendedPicker)bindable;
            picker.ItemsSource = (IList)newValue;
            loadItemsAndSetSelected(bindable);
        }

        static void loadItemsAndSetSelected(BindableObject bindable)
        {
            ExtendedPicker picker = (ExtendedPicker)bindable;
            if (picker.ItemsSource as IEnumerable != null)
            {
                int count = 0;
                foreach (object obj in (IEnumerable)picker.ItemsSource)
                {
                    string value = string.Empty;
                    if (picker.DisplayProperty != null)
                    {
                        var prop = obj.GetType().GetRuntimeProperties().FirstOrDefault(p => string.Equals(p.Name, picker.DisplayProperty, StringComparison.OrdinalIgnoreCase));
                        if (prop != null)
                        {
                            value = prop.GetValue(obj).ToString();
                        }
                    }
                    else
                    {
                        value = obj.ToString();
                    }
                    picker.Items.Add(value);
                    if (picker.SelectedItem != null)
                    {
                        if (picker.SelectedItem == obj)
                        {
                            picker.SelectedIndex = count;
                        }
                    }
                    count++;
                }
            }
        }
    }
}
