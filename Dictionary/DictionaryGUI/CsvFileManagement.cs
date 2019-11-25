using System.IO;
using System.Collections.Generic;
using DictionaryGUI.Data;

namespace DictionaryGUI
{
    class CsvFileManagement
    {
        readonly string path;

        public CsvFileManagement(string path)
        {
            if (File.Exists(path))
            {
                CreateNewFile(path).Close();
            }
            this.path = path;
        }

        public void Write(List<Word> list)
        {
            StreamWriter writer = new StreamWriter(path, false, System.Text.Encoding.UTF8);
            for (int i = 0; i < list.Count; i++)
            {
                writer.WriteLine(string.Join(";", list[i].word_o, list[i].type_id, list[i].word_m));
            }
            writer.Close();
        }

        private FileStream CreateNewFile(string path)
        {
            return File.Create(path);
        }
    }
}
