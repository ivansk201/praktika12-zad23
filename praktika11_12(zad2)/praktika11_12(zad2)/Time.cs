namespace praktika11_12_zad2_
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection.Emit;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace WindowsFormsApplication1
    {
        class Time
        {
            public int chas;
            public int minuta;
            public int sekunda;
            public int Chas()
            {                            
                if (chas > 0 && chas < 24)
                {}
                else 
                {
                    MessageBox.Show("Вы ввели недопустимое число в часе. Повторите попытку", "Ошибка",MessageBoxButtons.OK);
                    Process.GetCurrentProcess().Start();
                    
                }
                return chas;
            }
            public int Minuta()
            {
                if (minuta > 0 && minuta < 61)
                {}
                else
                { 
                    MessageBox.Show("Вы ввели недопустимое число в минуте. Повторите попытку", "Ошибка", MessageBoxButtons.OK);
                    Process.GetCurrentProcess().Start();
                }
                return minuta;
            }
            public int Sekunda()
            {
                if (sekunda > 0 && sekunda < 61)
                {
                
                }
                else 
                {
                    MessageBox.Show("Вы ввели недопустимое число в секунде. Повторите попытку", "Ошибка", MessageBoxButtons.OK);
                    Process.GetCurrentProcess().Start();
                }
                return sekunda;
            }
           
        }

    }
}
