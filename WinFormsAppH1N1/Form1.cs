using System.Runtime.InteropServices;

namespace WinFormsAppH1N1
{
    public partial class Form1 : Form
    {
        private const int MOUSEEVENTF_LEFTDOWN = 0X0002;
        private const int MOUSEEVENTF_LEFTOP = 0X0004;
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]

        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        //gera as posições aleatórias
        private Random random = new Random();

        private void MoverCursor()
        {
            int larguraTela = Screen.PrimaryScreen.Bounds.Width;
            int alturaTela = Screen.PrimaryScreen.Bounds.Height;
            int posicaoXAleatoria = random.Next(larguraTela);
            int posicaoYaleatoria = random.Next(alturaTela);
            Cursor.Position = new Point(posicaoXAleatoria, posicaoYaleatoria);
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
