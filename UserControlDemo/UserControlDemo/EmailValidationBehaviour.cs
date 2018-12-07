using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using Xamarin.Forms;

namespace UserControlDemo
{
    class EmailValidationBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += EmailValidation;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= EmailValidation;
            base.OnDetachingFrom(bindable);
        }

        private void EmailValidation(object sender, TextChangedEventArgs e)
        {
            Entry input = sender as Entry;
            input.TextColor = Color.Default;
            try
            {
                MailAddress mail = new MailAddress(input.Text);
            }
            catch (FormatException)
            {
                input.TextColor = Color.Red;
            }
        }
    }
}
