using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Text;

namespace ASFA.Helpers;

public class ManipularArquivoHelper
{
    public string ComprimirImagem(string caminhoImagem, string cpf, int larguraMax = 200, int qualidade = 75)
    {
        string novoCaminho = Path.Combine(Path.GetDirectoryName(caminhoImagem), cpf + Path.GetExtension(caminhoImagem));

        using (Bitmap imagemOriginal = new Bitmap(caminhoImagem))
        {
            // Calcula as novas dimensões mantendo a proporção
            int novaLargura, novaAltura;

            if (imagemOriginal.Width > larguraMax)
            {
                double ratio = (double)larguraMax / imagemOriginal.Width;
                novaLargura = larguraMax;
                novaAltura = (int)(imagemOriginal.Height * ratio);
            }
            else
            {
                novaLargura = imagemOriginal.Width;
                novaAltura = imagemOriginal.Height;
            }

            // Redimensiona a imagem
            using (Bitmap imagemRedimensionada = new Bitmap(novaLargura, novaAltura))
            {
                using (Graphics g = Graphics.FromImage(imagemRedimensionada))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(imagemOriginal, 0, 0, novaLargura, novaAltura);
                }

                // Configura os parâmetros de compressão JPEG
                var encoderParams = new EncoderParameters(1);
                encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qualidade);

                // Obtém o codec JPEG
                ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");

                imagemRedimensionada.Save(novoCaminho, jpegCodec, encoderParams);
            }
        }

        return novoCaminho;
    }

    private ImageCodecInfo GetEncoderInfo(string mimeType)
    {
        ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
        return codecs.FirstOrDefault(codec => codec.MimeType == mimeType);
    }

    public static string CalcularHash(string input)
    {
        var bytes = Encoding.UTF8.GetBytes(input);
        var hashBytes = SHA256.HashData(bytes);
        return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
    }
}
