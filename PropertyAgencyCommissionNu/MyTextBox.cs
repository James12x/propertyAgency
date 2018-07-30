using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyAgencyCommissionNu {
    public class MyTextBox : TextBox {
        public List<int> numberInTextBoxNominal = new List<int>();
        bool change = false;
        bool backSpace = false;
        string formatText() {
            
            string temp = "";
            int number = 3;
            if (numberInTextBoxNominal.Count < 4) {
                for (int i = 0; i < numberInTextBoxNominal.Count; i++) {
                    temp += numberInTextBoxNominal[i].ToString();
                }
                
            } else {
                int[] dotLocation = new int[0];
                Array.Resize(ref dotLocation, (numberInTextBoxNominal.Count - 1) / 3);

                for (int i = 0; i < dotLocation.Length; i++) {

                    if (i == 0) {
                        while (numberInTextBoxNominal.Count - 3 > number) {
                            number += 3;
                        }

                        dotLocation[i] = numberInTextBoxNominal.Count - number;
                    } else {
                        dotLocation[i] = dotLocation[i - 1] + 3;
                    }
                }

                int counterForDot = 0;
                for (int i = 0; i < numberInTextBoxNominal.Count; i++) {
                    if (dotLocation.Length > 0) {
                        if (counterForDot < dotLocation.Length && dotLocation[counterForDot] == i) {
                            temp += ",";
                            counterForDot++;
                        }
                    }

                    temp += numberInTextBoxNominal[i];
                }

            }
            
            return temp;
        }
        public void Format() {
            change = false;
            string temp = Text;
            string temp2 = temp.Replace(",", "");
            numberInTextBoxNominal.Clear();
            for (int i = 0; i < temp2.Length; i++) {
                numberInTextBoxNominal.Add(int.Parse(temp2[i].ToString()));
            }

            Text = formatText();
            
            if (!backSpace) {
                SelectionStart = Text.Length;
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
                

            } else {
                change = true;
                if (e.KeyChar != (char)Keys.Back) {
                    backSpace = false;
                }
            }
            base.OnKeyPress(e);
        }

        protected override void OnKeyDown(KeyEventArgs e) {
            if (e.KeyCode == Keys.Back) {
                backSpace = true;
                int a = SelectionStart;
                //  MessageBox.Show(a.ToString());
                SelectionStart = a;
                SelectionLength = 0;
            }
            base.OnKeyDown(e);
        }

        protected override void OnTextChanged(EventArgs e) {
            if (change && !backSpace) {
                Format();
            }
            base.OnTextChanged(e);
        }

        protected override void OnLeave(EventArgs e) {
            Format();
            base.OnLeave(e);
        }

        protected override void OnEnter(EventArgs e) {
            Format();
            base.OnEnter(e);
        }

        public double GetValue() {
            string value = "";
            for(int i = 0; i < numberInTextBoxNominal.Count; i++) {
                value += numberInTextBoxNominal[i];
            }
            if(value == "") {
                value = "0";
            }
            return double.Parse(value);
        }
    }
}
