namespace memoapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// �V�K�쐬�{�^���̑I��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadTextBox.Text = "";

        }

        /// <summary>
        /// �ǂݍ��݃{�^���̑I��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// �ۑ��{�^���̑I��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadSaveFileDialog.ShowDialog();
        }
        /// <summary>
        /// �t�@�C�����Ђ炭�@OK�{�^������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotepadOpenFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        /// <summary>
        /// �t�@�C���̕ۑ��@
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotepadSaveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StreamWriter sw = new StreamWriter(NotepadSaveFileDialog.FileName, false);
            sw.Write(NotepadTextBox.Text);
            sw.Close();
        }
    }
}
