namespace GodotModules
{
    public class PopupLineEdit : WindowDialog
    {
        [Export] protected readonly NodePath NodePathLineEdit;
        private LineEdit _lineEdit;

        private string _title;
        private PopupManager _popupManager;
        private Action<LineEdit> _onTextChanged;
        private Action<string> _onHide;
        private int _maxLength;
        private string _text;

        public void PreInit(PopupManager popupManager, Action<LineEdit> onTextChanged, Action<string> onHide, int maxLength = 50, string title = "", string text = "") 
        {
            _popupManager = popupManager;
            _title = title;
            _onTextChanged = onTextChanged;
            _onHide = onHide;
            _maxLength = maxLength;
            _text = text;
        }

        public override void _Ready()
        {
            _lineEdit = GetNode<LineEdit>(NodePathLineEdit);
            _lineEdit.MaxLength = _maxLength;
            WindowTitle = _title;
            _lineEdit.Text = _text;
        }

        private void _on_LineEdit_text_changed(string newText) => _onTextChanged(_lineEdit);

        private void _on_PopupLineEdit_popup_hide()
        {
            _onHide(_lineEdit.Text);
            _popupManager.Next();
            QueueFree();
        }

        private void _on_Ok_pressed() => Hide();
    }
}
