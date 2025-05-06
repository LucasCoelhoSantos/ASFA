using Microsoft.Reporting.WinForms;
using System.Diagnostics;

namespace ASFA.Helpers;

public static class RelatorioHelper
{
    public static void GerarPDF(ReportViewer report, string nomeArquivo, string path, ReportParameterCollection? parameters = null, ReportDataSource? dataSource = null)
    {
        try
        {
            report.LocalReport.ReportPath = Path.Combine(Application.StartupPath, "Reports", path);

            if (dataSource != null)
            {
                report.LocalReport.DataSources.Clear();
                report.LocalReport.DataSources.Add(dataSource);
            }

            if (parameters != null)
                report.LocalReport.SetParameters(parameters);

            report.Refresh();
            report.RefreshReport();

            byte[] bytes = report.LocalReport.Render("PDF", null, out _, out _, out _, out _, out _);
            string caminhoArquivo = Path.Combine(Application.StartupPath, nomeArquivo + ".pdf");

            File.WriteAllBytes(caminhoArquivo, bytes);

            AbrirPDF(caminhoArquivo);
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError($"Erro ao Gerar PDF: {ex.Message}");
        }
    }

    private static void AbrirPDF(string caminhoArquivo)
    {
        try
        {
            using var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = caminhoArquivo,
                    UseShellExecute = true
                }
            };
            process.Start();
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError($"Erro ao abrir PDF: {ex.Message}");
        }
    }
}
