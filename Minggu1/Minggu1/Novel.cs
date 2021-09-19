using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minggu1
{
    class Novel
    {
        private string judul;
        public int stock { get; set; }
        public int harga { get; set; }
        private List<int> genre;
        private bool hardCover;

        public Novel(string judul, int stock, int harga, List<int> genre, bool hardCover)
        {
            this.judul = judul;
            this.stock = stock;
            this.harga = harga;
            this.genre = genre;
            this.hardCover = hardCover;
        }

        public string Judul { get => judul; set => judul = value; }
        public List<int> Genre { get => genre; set => genre = value; }
        public bool HardCover { get => hardCover; set => hardCover = value; }

        public override string ToString()
        {
            string cover = this.hardCover ? "Hard Cover" : "Soft Cover";
            string genreDisp = "";
            for (int i = 0; i < genre.Count; i++)
            {
                if (genre[i] == 1) genreDisp += "R";
                else if (genre[i] == 2) genreDisp += "C";
                else if (genre[i] == 3) genreDisp += "H";
                if (i < genre.Count - 1) genreDisp += ", ";
            }
            return $"{this.judul} - {this.stock} - {cover} - {genreDisp} - {this.harga}";
        }
    }
}
