using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_задание_3_курс
{
    public delegate void CalcBack(string s);
    public delegate void CalcDelegate(string n, CalcBack PrintResult);
    
    class Element
    {
        private static int _Count; 
        private int _ID;
        private string _First, _Second;

        private CheckedListBox _LB;


        public Element() : this("д","е", null) { }
        public Element(string First, string Second, CheckedListBox LB)
        {
            _ID = ++_Count;
            _First = string.IsNullOrWhiteSpace(First) ? "д" : First;
            _Second = string.IsNullOrWhiteSpace(Second) ? "е" : Second;
            _LB = LB;
        }

        public string First
        {
            get { return _First; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _First = value;

                if (_LB != null && _LB.Items.IndexOf(this) >= 0)
                    _LB.Items[_LB.Items.IndexOf(this)] = this;
            }
        }
        public string Second
        {
            get { return _Second; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _Second = value;

                if (_LB != null && _LB.Items.IndexOf(this) >= 0)
                    _LB.Items[_LB.Items.IndexOf(this)] = this;
                
            }
        }

        public override string ToString()
        {
            return _ID + ": (" + First + ") (" + _Second + ")";
        }

        public void AddToMinLength(string n, CalcBack PrintResult)
        {

            if (_First.Length < _Second.Length)
                _First += n;
            else
                _Second += n;

            if (_LB != null && _LB.Items.IndexOf(this) >= 0)
                _LB.Items[_LB.Items.IndexOf(this)] = this;

            PrintResult(string.Format(
            "Строка \"{0}\" добавлена к наименьшему полю ", n));
        }

        public void ReplacingWithLongest(string n, CalcBack PrintResult)
        {
            if (_First.Length > _Second.Length)
                _First = n;
            else
                _Second = n;

            if (_LB != null && _LB.Items.IndexOf(this) >= 0)
                _LB.Items[_LB.Items.IndexOf(this)] = this;

            PrintResult(string.Format(
             "Строка \"{0}\" заменена у наименьшего поля ", n));

        }
    }
}
