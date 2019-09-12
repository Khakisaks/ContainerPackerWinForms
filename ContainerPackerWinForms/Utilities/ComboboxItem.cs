namespace ContainerPackerWinForms
{
    public class ComboboxItem
    {
        #region Properties

        public string Text { get; set; }
        public object Value { get; set; }

        #endregion

        #region Helper Methods

        public override string ToString()
        {
            return Text;
        }

        #endregion
    }
}
