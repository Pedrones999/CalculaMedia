using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Media.Modelos;
using System.Drawing.Imaging;

namespace Media
{
    public  class GeradorPDF
    {
        private readonly string DEST;
        private readonly Aluno aluno;
        private readonly bool notaLetra;
        private readonly int numPeriodos;
        private readonly int periodoPreenchido;
        private float[] LargurasColunas;
        private string nomenclatura;
        private string[] notasLetras = new string[] { };
        private string[] notas = new string[]{};


        public GeradorPDF(Aluno donoDoBoletim, string caminho, bool notasEmLetra, int quantosPeriodos, int periodoPreencher) 
        {
            aluno = donoDoBoletim;
            notaLetra = notasEmLetra;
            numPeriodos = quantosPeriodos;
            periodoPreenchido = periodoPreencher;
            DEST = caminho+$@"\{aluno.Nome}_Boletim.pdf";

            foreach(Materia materia in aluno.Materias)
            {
                if (materia != null)
                {
                    double media = materia.CalculaMedia();
                    if (media.ToString() != null)
                    {
                        notas.Append($"{media}");
                        notasLetras.Append(materia.NotaPraLetra(media));
                    }
                }
            }
        }

        public void CriarBoletim ()
        {
            var meuVerde = new DeviceRgb(0.7f, 1.5F, 0.7f);

            using (PdfWriter wPdf = new(DEST, new WriterProperties()
                .SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var documentoPdf = new PdfDocument(wPdf);
                var documento = new Document(documentoPdf, PageSize.A4);

                if (numPeriodos == 3)
                {
                    LargurasColunas = new float[]{ 30, 15, 15, 15, 15};
                    nomenclatura = "trimestre";
                }
                if (numPeriodos == 4)
                {
                    LargurasColunas = new float[]{ 25, 12, 12, 12, 12, 15};
                    nomenclatura = "bimestre";
                }
                if (numPeriodos != 3 &&  numPeriodos != 4)
                {
                    return;
                }
                Table tabela = new Table(UnitValue.CreatePercentArray(LargurasColunas))
                    .UseAllAvailableWidth();

                var fonte = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                tabela.AddHeaderCell(new Cell(1,1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBackgroundColor(meuVerde)
                    .Add(new Paragraph("componente curricular"))
                    );
                for(int i = 0; i < numPeriodos; i++) 
                {                 
                tabela.AddHeaderCell(new Cell(1,1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBackgroundColor(meuVerde)
                    .Add(new Paragraph($"{i + 1}º{nomenclatura}"))
                    );
                }
                tabela.AddHeaderCell(new Cell(1, 1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBackgroundColor(meuVerde)
                    .Add(new Paragraph("Media final"))
                    );

                foreach (Materia materia in aluno.Materias)
                {
                    string media;

                    if (notaLetra)
                    {
                        media = materia.CalculaMedia().ToString();
                    }
                    else
                    {
                        media = materia.NotaPraLetra(materia.CalculaMedia());
                    }

                    tabela.AddCell(new Cell(1, 1)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetBackgroundColor(meuVerde)
                        .Add(new Paragraph(materia.Nome)));

                    for (int i = 0;i <= numPeriodos ;i++) 
                    {

                        if(i + 1 == periodoPreenchido)
                        {
                            tabela.AddCell(new Cell(1, 1)
                                .SetTextAlignment(TextAlignment.CENTER)
                                .Add(new Paragraph(media)));
                        }
                        else
                        {
                            tabela.AddCell(new Cell(1, 1));
                        }
                    
                    }
                }

                documento.Add(tabela);

                documento.Close();
                documentoPdf.Close();
            }
        }
    }
}
