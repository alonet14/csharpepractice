// using System;
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Data;
// using System.Drawing;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
//
// namespace Example
// {
//     public partial class Form1 : Form
//     {
//         public Form1()
//         {
//             this.WindowState = FormWindowState.Maximized;
//             this.Text = "Test Point class";
//
//             var mainContent = new Panel {
//                 Dock = DockStyle.Fill,
//                 BackColor = System.Drawing.Color.Black,
//             };
//             var propGrid = new PropertyGrid {
//                 Dock = DockStyle.Fill,
//             };
//             var layout = new SplitContainer {
//                 Dock = DockStyle.Fill,
//                 FixedPanel = FixedPanel.Panel2,
//             };
//
//             layout.Panel1.Controls.Add(mainContent);
//             layout.Panel2.Controls.Add(propGrid);
//
//             this.Controls.Add(layout);
//
//             this.Load += (s, e) => {
//                 layout.SplitterDistance = this.Width - 400;
//             };
//
//             var point = new Point(100, 100);
//             var brush = Brushes.Lime;
//             int r = 8;
//
//             propGrid.SelectedObject = point;
//             propGrid.PropertyValueChanged += (s, e) => {
//                 mainContent.Invalidate();
//             };
//             mainContent.Paint += (s, e) => {
//
//                 e.Graphics.FillEllipse(brush, point.X - r, point.Y - 4, r * 2, r * 2);
//
//             };
//         }
//     }
// }