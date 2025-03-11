namespace StockPulse.GUI
{
    public class StatusBarManager
    {
        private static StatusBarManager? instance;
        public StatusStrip StatusBar { get; private set; }
        private static ToolStripStatusLabel? statusLabel;
        public static int Height { get; private set; }

        public static bool isHasText => statusLabel?.Text != "";
        private StatusBarManager()
        {
            StatusBar = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            StatusBar.Items.Add(statusLabel);
            Height = StatusBar.Height;
        }

        public static StatusBarManager NewStatusBar
        {
            get
            {
                if (instance == null)
                    instance = new StatusBarManager();
                return instance;
            }
        }

        public static void UpdateStatus(string? message)
        {
            if (message == null || statusLabel == null)
            {
                return;
            }

            statusLabel.Text = message;
        }

    }

}
