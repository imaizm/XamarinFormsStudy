using System;
using Xamarin.Forms;

namespace XamarinFormsStudy.Behaviors
{
    public class ItemSelectedToCommandBehavior : Behavior<ListView>
    {
        public ItemSelectedToCommandBehavior()
        {
        }

        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.ItemSelected += (s, e) =>
            {
                if (e.SelectedItem != null)
                {
                    
                }
            };
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
        }

        private void ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
