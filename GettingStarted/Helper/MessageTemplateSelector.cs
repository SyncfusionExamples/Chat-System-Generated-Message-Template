using Syncfusion.XForms.Chat;
using Xamarin.Forms;

namespace GettingStarted
{
    public class MessageTemplateSelector : ChatMessageTemplateSelector
    {
        private readonly DataTemplate customMessageTemplate;
        public MessageTemplateSelector(SfChat sfChat):base(sfChat)
        {
            this.customMessageTemplate = new DataTemplate(typeof(CustomMessageTemplate));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var message = item as IMessage;
            if (message == null)
                return null;

            if (item as ITextMessage != null)
            {
                if ((item as ITextMessage).Author == null)
                {
                    return customMessageTemplate;
                }
                else
                {
                    return base.OnSelectTemplate(item,container);
                }
            }
            else
            {
                return null;
            }
        }
    }
}
