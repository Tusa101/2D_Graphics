using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _2D_Graphics
{
    public partial class Form1 : Form
    {
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Oemplus:
                    {
                        _movingSpeed++;
                        Text = String.Format("Speed: {0}", _movingSpeed.ToString());
                        e.Handled = true;
                    }
                    break;
                case Keys.OemMinus:
                    {
                        _movingSpeed--;
                        Text = String.Format("Speed: {0}", _movingSpeed.ToString());
                        e.Handled = true;
                    }
                    break;
                case Keys.Escape:
                    {
                        clearButton.PerformClick();
                        e.Handled = true;
                    }
                    break;
                //case Keys.Up:
                //    {
                        
                //        //e.Handled = true;
                //    }
                //    break;
                //case Keys.Down:
                //    {
                //        if (_movingEnabled)
                //        {
                //            _direction = Math.Abs((_direction - 1) % 4);
                //            Text = String.Format("Speed: {0}", _movingSpeed.ToString());
                //        }
                //        e.Handled = true;
                //    }
                //    break;
                default:
                    break;
                    
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool IsHandled = true;
            switch (msg.WParam.ToInt32())
            {
                case (0x20):
                    {
                        movePaintingButton.PerformClick();
                        IsHandled = true;
                    }
                    break;
                case (38):
                    {
                        if (_movingEnabled)
                        {
                            _direction = Math.Abs((_direction + 1) % 4+1);
                            Text = String.Format("Direction: {0}", _direction.ToString());
                        }
                        IsHandled = true;
                    }break;
                case (40):
                    {
                        if (_movingEnabled)
                        {
                            _direction = Math.Abs((_direction - 1) % 4 + 1);
                            Text = String.Format("Direction: {0}", _direction.ToString());
                        }
                        IsHandled = true;
                    }
                    break;
                default: 
                    IsHandled = false; break;
            }
            return IsHandled;
        }
    }
}
