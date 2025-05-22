using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIsk_Scheduling
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
            this.ClientSize = new Size(800, 800);
            string helpText =
                "🖥️ USER GUIDE\r\n" +
                "💿 Disk Scheduling Simulator\r\n\r\n" +

                "🔢 1. Enter the Initial Head Position:\r\n" +
                "- Enter a positive integer. Example: 50\r\n\r\n" +

                "📥 2. Enter Track Requests:\r\n" +
                "- Input track numbers separated by commas (,).\r\n" +
                "- Example: 98, 183, 37, 122, 14, 124, 65, 67\r\n\r\n" +

                "⚙️ 3. Select a Scheduling Algorithm:\r\n" +
                "- FCFS – First Come First Serve\r\n" +
                "- SSTF – Shortest Seek Time First\r\n" +
                "- SCAN\r\n" +
                "- LOOK\r\n" +
                "- C-SCAN\r\n" +
                "- C-LOOK\r\n\r\n" +

                "▶️ 4. Click the 'START' Button:\r\n" +
                "- The app will simulate disk head movement using the selected algorithm.\r\n\r\n" +

                "📊 5. View the Results:\r\n" +
                "- The order in which tracks are serviced.\r\n" +
                "- Disk head path (with animation if enabled).\r\n" +
                "- Total head movement calculated.\r\n\r\n" +

                "💡 Tips:\r\n" +
                "- Try different algorithms to compare performance.\r\n" +
                "- Use shorter input to better observe the animation.\r\n\r\n" +

                "⚠️ Attention:\r\n" +
                "- All entered track numbers must be between 0 and 199.\r\n" +
                "- Values outside this range will be rejected.\r\n\r\n" +

                "🎉 Thank you for using Disk Scheduling Simulator!";

            txtHelp.Text = helpText;
            txtHelp.SelectionStart = 0;
            txtHelp.SelectionLength = 0;
        }
    }
}
