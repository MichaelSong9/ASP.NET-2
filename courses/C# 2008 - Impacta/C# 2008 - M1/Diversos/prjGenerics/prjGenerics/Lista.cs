using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace prjGenerics
{
    class Lista<T>
    {
        public ArrayList obj = new ArrayList();

        public void Incluir(T item)
        {
            obj.Add(item);
        }

        public void Descarregar(ListBox lst)
        {
            lst.Items.Clear();
            foreach (T item in obj)
            {
                lst.Items.Add(item);
            }
        }
    }
}
