using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Font = System.Drawing.Font;

namespace Projeto_de_Extensão.Formulários.Perguntas
{
    public partial class FrmPergunta : Form
    {
        public FrmPergunta()
        {
            InitializeComponent();
            CriarAlternativas();
        }

        public void CriarAlternativas()
        {
            var Alternativas = new List<string>
            {
                "não","sim"
            };

            criaButton(Alternativas);
        }


        public void criaButton(List<string> Alternativas)
        {
            int cont = 0;
            int espacamento = 30;
            int posicaoY = 10;

            int qtdAlternativas = Alternativas.Count();

            int larguraGroupBox = grbAlternativas.Width;

            if( qtdAlternativas < 4)
            {
                foreach (var alternativas in Alternativas)
                {
                    Button radioButton = new Button
                    {
                        Text = "aaaaaaaaaaa" + alternativas,
                        AutoSize = true,
                        Font = new Font("Arial", 12),
                        Name = $"rbAlternativa{cont}"
                    };
                    /*RadioButton radioButton = new RadioButton
                    {
                        Text = "aaaaaaaaaaa" + alternativas,
                        AutoSize = true,
                        Font = new Font("Arial", 12),
                        Name = $"rbAlternativa{cont}"
                    };
                    */
                    int posicaoX = (larguraGroupBox - radioButton.Width) / 8;

                    radioButton.Location = new Point(posicaoX, posicaoY);

                    grbAlternativas.Controls.Add(radioButton);
                    posicaoY += espacamento;
                    cont++;
                }
            }
            if ( qtdAlternativas > 4 )
            {
                foreach (var alternativas in Alternativas)
                {
                    RadioButton radioButton = new RadioButton
                    {
                        Text = "aaaaaaaaaaa" + alternativas,
                        AutoSize = true,
                        Font = new Font("Arial", 12),
                        Name = $"rbAlternativa{cont}"
                    };
                    
                    int posicaoX = (larguraGroupBox - radioButton.Width) / 8;

                    radioButton.Location = new Point(posicaoX, posicaoY);

                    grbAlternativas.Controls.Add(radioButton);
                    posicaoY += espacamento;
                    cont++;
                }
            }
            
        }
        
        
    }
}
