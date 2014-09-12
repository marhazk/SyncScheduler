using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Security.Cryptography;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

delegate void SetTextCallbackType(object text, object type = null);
delegate void SetTextCallbackListBox(ListBox obj, object text);
delegate void SetTextCallbackListBoxClear(ListBox obj);
delegate void SetTextCallbackListBoxEdit(ListBox obj, int id, object text);
delegate void SetTextCallbackTextBox(TextBox obj, object text);
delegate void SetTextCallbackListBoxCombo(ComboBox obj, object text);
delegate void SetTextCallbackListBoxComboAdd(ComboBox obj, int num, object text);
delegate void SetTextCallbackListBoxComboBool(ComboBox obj, bool value);
delegate void SetTextCallbackListBoxChkBool(CheckBox obj, bool value);
delegate void SetTextCallbackComboBoxClear(ComboBox obj);
delegate void SetTextCallbackButton(Button obj, bool value);
delegate void SetTextCallbackButton03(Button obj, object value);
delegate void SetTextCallbackButtonHide(Button obj, bool value, bool value2);
delegate void SetTextCallbackLabel(Label obj, object text);
delegate void SetTextCallbackProgressBar(ProgressBar obj, bool value);
delegate void SetTextCallbackProgressBar2(ProgressBar obj, bool value, int x1, int x2, int x3);

delegate void SetTextCallbackTC00(TabControl obj, bool temp);
delegate void SetTextCallbackTP00(TabPage obj, bool temp);

//FormThread v2.1 writen by MarHazK (6 Feb 2014)
namespace SyncScheduler
{
    public interface FormInterfaces
    {
        void send(ComboBox obj);
        void send(ComboBox obj, bool _temp);
        void send(ComboBox obj, object _temp);
        void send(ComboBox obj, int num, object _temp);
        void send(Button obj, object _temp);
        void send(Button obj, bool _temp);
        void send(Button obj, bool _temp, bool _temp2);
        void send(ListBox obj);
        void send(ListBox obj, int id, object _temp);
        void send(ListBox obj, object _temp);
        void send(TextBox obj, object _temp);
        void send(Label obj, object _temp);
        void send(ProgressBar obj, bool _temp);
        void send(ProgressBar obj, bool _temp, int _temp2, int _temp3, int _temp4);
        void send(TabControl obj, bool _temp);
        void send(TabPage obj, bool _temp);
    }
    class FormThread : FormInterfaces
    {
        public FormThread() { }
        public FormThread(ListBox obj, object _temp) { send(obj, _temp); }
        public FormThread(ComboBox obj, object _temp) { send(obj, _temp); }
        public FormThread(ComboBox obj, int num, object _temp) { send(obj, num, _temp); }
        public FormThread(ComboBox obj, bool _temp) { send(obj, _temp); }
        public FormThread(Button obj, bool _temp) { send(obj, _temp); }
        public FormThread(ListBox obj, int id, object _temp) { send(obj, id, _temp); }
        public FormThread(Button obj, bool _temp, bool _temp2) { send(obj, _temp, _temp2); }
        public FormThread(ProgressBar obj, bool _temp) { send(obj, _temp); }
        public FormThread(ListBox obj) { send(obj); }
        public FormThread(ComboBox obj) { send(obj); }
        public FormThread(TextBox obj, object _temp) { send(obj, _temp); }
        public FormThread(Label obj, object _temp) { send(obj, _temp); }
        public FormThread(ProgressBar obj, bool _temp, int _temp2, int _temp3, int _temp4) { send(obj, _temp, _temp2, _temp3, _temp4); }

        public void send(ListBox obj, int id, object _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackListBoxEdit d = new SetTextCallbackListBoxEdit(send);
                    Program.Form.Invoke(d, new object[] { obj, id, _temp });
                }
                else
                {
                    obj.Items.RemoveAt(id);
                    obj.Items.Insert(id, _temp);
                }
            }
            catch { }
        }
        public void send(ListBox obj)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackListBoxClear d = new SetTextCallbackListBoxClear(send);
                    Program.Form.Invoke(d, new object[] { obj });
                }
                else
                {
                    obj.Items.Clear();
                }
            }
            catch { }
        }
        public void send(ComboBox obj)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackComboBoxClear d = new SetTextCallbackComboBoxClear(send);
                    Program.Form.Invoke(d, new object[] { obj });
                }
                else
                {
                    obj.Items.Clear();
                }
            }
            catch { }
        }
        public void send(ListBox obj, object _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackListBox d = new SetTextCallbackListBox(send);
                    Program.Form.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Items.Insert(0, _temp);
                }
            }
            catch { }
        }
        public void send(ComboBox obj, object _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackListBoxCombo d = new SetTextCallbackListBoxCombo(send);
                    Program.Form.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Items.Insert(0, _temp);
                }
            }
            catch { }
        }
        public void send(ComboBox obj, int num, object _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackListBoxComboAdd d = new SetTextCallbackListBoxComboAdd(send);
                    Program.Form.Invoke(d, new object[] { obj, num, _temp });
                }
                else
                {
                    obj.Items.Insert(num, _temp);
                }
            }
            catch { }
        }
        public void send(ComboBox obj, bool _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackListBoxComboBool d = new SetTextCallbackListBoxComboBool(send);
                    Program.Form.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Enabled = _temp;
                }
            }
            catch { }
        }
        public void send(CheckBox obj, bool _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackListBoxChkBool d = new SetTextCallbackListBoxChkBool(send);
                    Program.Form.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Checked = _temp;
                }
            }
            catch { }
        }
        public void send(ProgressBar obj, bool _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackButton d = new SetTextCallbackButton(send);
                    Program.Form.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Visible = _temp;
                }
            }
            catch { }
        }
        public void send(ProgressBar obj, bool _temp, int _temp2, int _temp3, int _temp4)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackButton d = new SetTextCallbackButton(send);
                    Program.Form.Invoke(d, new object[] { obj, _temp, _temp2, _temp3, _temp4 });
                }
                else
                {
                    obj.Visible = _temp;
                    obj.Minimum = _temp2;
                    obj.Value = _temp3;
                    obj.Maximum = _temp4;
                }
            }
            catch { }
        }
        public void send(Button obj, bool _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackButton d = new SetTextCallbackButton(send);
                    Program.Form.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Enabled = _temp;
                }
            }
            catch { }
        }
        public void send(Button obj, object _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackButton03 d = new SetTextCallbackButton03(send);
                    Program.Form.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Text = (string)_temp;
                }
            }
            catch { }
        }
        public void send(Button obj, bool _temp, bool _temp2)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackButton d = new SetTextCallbackButton(send);
                    Program.Form.Invoke(d, new object[] { obj, _temp, _temp2 });
                }
                else
                {
                    obj.Visible = _temp2;
                    obj.Enabled = _temp;
                }
            }
            catch { }
        }
        public void send(TextBox obj, object _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackTextBox d = new SetTextCallbackTextBox(send);
                    Program.Form.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Text = (string)_temp;
                }
            }
            catch { }
        }
        public void send(Label obj, object _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackLabel d = new SetTextCallbackLabel(send);
                    Program.Form.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Text = (string)_temp;
                }
            }
            catch { }
        }
        public void send(TabControl obj, bool _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackTC00 d = new SetTextCallbackTC00(send);
                    Program.Form.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Visible = _temp;
                    if (_temp == true)
                        obj.Select();
                }
            }
            catch { }
        }
        public void send(TabPage obj, bool _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackTP00 d = new SetTextCallbackTP00(send);
                    Program.Form.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Enabled = _temp;
                    if (_temp == true)
                        obj.Select();
                }
            }
            catch { }
        }

    }
}
