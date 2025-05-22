using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DIsk_Scheduling
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            this.ClientSize = new Size(800, 800);
            string aboutText =
                "ABOUT US\r\n" +
                "=========\r\n\r\n" +
                "Disk Scheduling Simulator\r\n" +
                "Version: 1.0.0\r\n" +
                "Release Date: May 2025\r\n" +
                "Developed by: HMDuck & VTTam\r\n\r\n" +

                "Overview:\r\n" +
                "This application is built to help students and professionals understand how disk scheduling algorithms work.\r\n" +
                "It offers a visual and interactive approach to demonstrate how different algorithms control disk head movements.\r\n\r\n" +

                "Key Features:\r\n" +
                "- Support for multiple scheduling algorithms: FCFS, SSTF, SCAN, LOOK, C-SCAN, and C-LOOK\r\n" +
                "- Real-time animation of disk head movement based on user-defined requests\r\n" +
                "- Automatic calculation of total head movement for performance analysis\r\n" +
                "- User-friendly interface for entering and managing request queues\r\n\r\n" +

                "Purpose:\r\n" +
                "The main goal of this simulator is to help users better understand the behavior and efficiency\r\n" +
                "of various disk scheduling techniques. By visualizing the algorithm's operation,\r\n" +
                "users gain a deeper insight than through theoretical explanation alone.\r\n\r\n" +

                "Target Audience:\r\n" +
                "- Computer science students\r\n" +
                "- Educators and instructors\r\n" +
                "- Anyone curious about how operating systems manage disk access\r\n\r\n" +

                "Contact & Support:\r\n" +
                "For questions, suggestions, or bug reports, feel free to reach out:\r\n" +
                "Email: huynhmyduc2005@gmail.com\r\n" +
                "GitHub: https://github.com/HMD-CVA/DIskScheduling\r\n\r\n" +

                "Thank you for using Disk Scheduling Simulator!";
            
            txtAboutUs.Text = aboutText;
            txtAboutUs.Focus();
        }
    }
}
