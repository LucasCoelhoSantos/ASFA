using System.Text.RegularExpressions;

namespace ASFA.Helpers;

public static class ValidacaoHelper
{
    public static void ValidarDadosLogin(string login, string senha)
    {
        if (string.IsNullOrWhiteSpace(login)) 
            throw new ArgumentException("O campo login não pode estar vazio.");
        
        if (string.IsNullOrWhiteSpace(senha)) 
            throw new ArgumentException("O campo senha não pode estar vazio.");
        
        if (senha.Length < 6) 
            throw new ArgumentException("A senha deve ter pelo menos 6 caracteres.");
    }

    public static bool ValidarCPF(string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf))
            return false;

        // Remove caracteres não numéricos
        cpf = Regex.Replace(cpf, @"\D", "");

        if (cpf.Length != 11)
            return false;

        // Verifica se todos os dígitos são iguais (ex.: 111.111.111-11)
        if (cpf.Distinct().Count() == 1)
            return false;

        // Calcula os dígitos verificadores
        int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        string tempCpf = cpf.Substring(0, 9);
        int soma = tempCpf.Select((t, i) => (t - '0') * multiplicadores1[i]).Sum();
        int resto = (soma * 10) % 11;
        resto = (resto == 10) ? 0 : resto;

        if (resto != (cpf[9] - '0'))
            return false;

        tempCpf += resto;
        soma = tempCpf.Select((t, i) => (t - '0') * multiplicadores2[i]).Sum();
        resto = (soma * 10) % 11;
        resto = (resto == 10) ? 0 : resto;

        return resto == (cpf[10] - '0');
    }

    public static bool ValidarRG(string rg)
    {
        if (rg.Length < 7 || rg.Length > 9)
            return false;
        
        return true;
    }

    public static bool ValidarDataNascimento(DateTime dataNascimento)
    {
        DateTime dataMinima = new(1900, 1, 1);
        DateTime dataMaxima = DateTime.Today;

        if (dataNascimento < dataMinima || dataNascimento > dataMaxima)
            return false;

        return true;
    }

    public static void AdicionarErroCampoNulo(string campo, string nomeCampo, List<string> erros)
    {
        if (string.IsNullOrEmpty(campo))
            erros.Add(nomeCampo);
    }

    public static void AdicionarErroRadioButtonDesmarcado(RadioButton radioButtonNao, RadioButton radioButtonSim, string nomeCampo, List<string> erros)
    {
        if (!radioButtonNao.Checked && !radioButtonSim.Checked)
            erros.Add(nomeCampo);
    }

    public static void AdicionarErroComboBoxNaoSelecionado(ComboBox comboBox, string nomeCampo, List<string> erros)
    {
        if (comboBox.SelectedIndex == -1)
            erros.Add(nomeCampo);
    }

    public static void HabilitarCampoAdicional(RadioButton radioButton, Control control, bool habilitar)
    {
        if (radioButton.Checked)
        {
            control.Enabled = habilitar;

            if (!habilitar)
                ClearControlValue(control);
        }
    }

    public static void HabilitarCamposAdicionais(RadioButton radioButton, Control control1, Control control2, bool habilitar)
    {
        if (radioButton.Checked)
        {
            control1.Enabled = habilitar;
            control2.Enabled = habilitar;

            if (!habilitar)
            {
                ClearControlValue(control1);
                ClearControlValue(control2);
            }
        }
    }

    private static void ClearControlValue(Control control)
    {
        if (control is TextBox textBox)
            textBox.Clear();
        else if (control is ComboBox comboBox)
            comboBox.SelectedIndex = -1;
        else if (control is RadioButton radioButton)
            radioButton.Checked = false;
    }
}
