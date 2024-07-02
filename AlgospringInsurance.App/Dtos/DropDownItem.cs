namespace AlgospringInsurance.App.Dtos
{
    public class DropDownItem
    {
        public DropDownItem()
        {
            
        }

        public DropDownItem(string value, string text)
        {
            Value = value;
            Text = text;
        }

        public string Value { get; set; } = string.Empty;

        public string Text { get; set; } = string.Empty;
    }
}
