using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;
using System.Drawing;

namespace RickshawTradeTimer {
    public static class CopyEvents {
        public static TextBox CopyAttr(TextBox mold, TextBox clay, int y, Dictionary<object, string> defaultStates, Dictionary<object, string> toolTips) {
            CopyEvnts(mold, clay);

            clay.Text = defaultStates[mold];
            clay.BorderStyle = mold.BorderStyle;
            clay.Location = new Point(mold.Location.X, y);
            clay.ForeColor = Color.Gray;
            clay.Size = mold.Size;
            defaultStates[clay] = defaultStates[mold];
            toolTips[clay] = toolTips[mold];
            return clay;
        }

        public static  ComboBox CopyAttr(ComboBox mold, ComboBox clay, int y, Dictionary<object, string> defaultStates, Dictionary<object, string> toolTips) {
            CopyEvnts(mold, clay);
            
            clay.Text = defaultStates[mold];
            clay.FlatStyle = mold.FlatStyle;
            clay.Location = new Point(mold.Location.X, y);
            clay.ForeColor = Color.Gray;
            foreach(object item in mold.Items) clay.Items.Add(item);
            defaultStates[clay] = defaultStates[mold];
            toolTips[clay] = toolTips[mold];
            return clay;
        }

        public static  Button CopyAttr(Button mold, Button clay, int y, Dictionary<object, string> defaultStates, Dictionary<object, string> toolTips) {
            CopyEvnts(mold, clay);

            clay.Text = mold.Text;
            clay.Size = mold.Size;
            clay.FlatStyle = mold.FlatStyle;
            clay.Location = new Point(mold.Location.X, y + mold.Location.Y);
            return clay;
        }

        public static  void CopyEvnts(Control mold, Control clay) {
            var eventsField = typeof(Component).GetField("events", BindingFlags.NonPublic | BindingFlags.Instance);
            var eventHandlerList = eventsField.GetValue(mold);
            eventsField.SetValue(clay, eventHandlerList);
        }
    }
}
