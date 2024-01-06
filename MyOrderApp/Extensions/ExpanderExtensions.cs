namespace MyOrderApp.Extensions;

public static class ExpanderExtensions
{
    public static T Header<T>(this T item, IView content) where T : Expander
    {
        item.SetValue(Expander.HeaderProperty, content);

        return item;
    }

    public static T Contents<T>(this T item, IView content) where T : Expander
    {
        item.SetValue(Expander.ContentProperty, content);

        return item;
    }

    public static T IsExpanded<T>(this T item, bool isExpanded) where T : Expander
    {
        item.SetValue(Expander.IsExpandedProperty, isExpanded);

        return item;
    }
}
