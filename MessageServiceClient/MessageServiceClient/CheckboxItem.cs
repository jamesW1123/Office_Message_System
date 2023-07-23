namespace MessageServiceClientApp
{
    public class CheckboxItem
    {
        public string DisplayName { get; set; }
        public string UserName { get; set; }

        public CheckboxItem(string displayname, string username)
        {
            DisplayName = displayname;
            UserName = username;
        }
    }
}