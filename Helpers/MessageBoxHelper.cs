namespace ASFA.Helpers;

public static class MessageBoxHelper
{
    public static void ShowError(string message)
    {
        MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void ShowWarning(string message)
    {
        MessageBox.Show(message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public static void ShowSuccess(string message)
    {
        MessageBox.Show(message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static DialogResult ShowConfirmation(string message)
    {
        return MessageBox.Show(message, "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
    }

    public static DialogResult ShowUpdateOption(string message)
    {
        return MessageBox.Show(message, "Atualização disponível", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
    }
}
