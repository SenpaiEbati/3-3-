using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_задание_3_курс
{
    public delegate void CalcBack(string s);
    public delegate void CalcDelegate(int n, CalcBack PrintResult);
    
    class Element
    {
        private static int _Count; // Счетчик объектов
        private int _ID, _First, _Second;
        // Ссылка на компонент отображения
        private CheckedListBox _LB;

        // Конструкторы
        public Element() : this(1, 1, null) { }
        public Element(int First, int Second, CheckedListBox LB)
        {
            _ID = ++_Count;
            _First = First;
            _Second = Second != 0 ? Second : 1;
            _LB = LB;
        }
        // Свойства для работы с полями
        public int First
        {
            get { return _First; }
            set
            {
                _First = value;
                // Изменение отображения объекта в компоненте
                if (_LB != null && _LB.Items.IndexOf(this) >= 0)
                    _LB.Items[_LB.Items.IndexOf(this)] = this;
            }
            }
        public int Second
        {
            get { return _Second; }
            set
            {
                if (value != 0)
                {
                    _Second = value;
                    // Изменение отображения объекта в компоненте
                    if (_LB != null && _LB.Items.IndexOf(this) >= 0)
                        _LB.Items[_LB.Items.IndexOf(this)] = this;
                }
            }
        }
        // Переопределение метода отображения объекта
        public override string ToString()
        {
            return _ID + " : " + First + "/" + _Second;
        }
        // Первый обязательный метод
        public void AddFirst(int n, CalcBack PrintResult)
        {
            // Выполнение операции
            _First += n;
            // Изменение отображения объекта в компоненте
            if (_LB != null && _LB.Items.IndexOf(this) >= 0)
                _LB.Items[_LB.Items.IndexOf(this)] = this;
            // Вызов делегата для возврата требуемой строки
            PrintResult(string.Format(
            "Объект №{0}. Добавлено {1} к первому числу", _ID, n));
        }
        // Второй обязательный метод
        public void AddSecond(int n, CalcBack PrintResult)
        {
            _Second = _Second + n != 0 ? _Second + n : 1;
            if (_LB != null && _LB.Items.IndexOf(this) >= 0)
                _LB.Items[_LB.Items.IndexOf(this)] = this;
            PrintResult(string.Format(
            "Объект №{0}. Добавлено {1} ко второму числу", _ID, n));

        }
    }
}
