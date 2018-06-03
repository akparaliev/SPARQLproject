using SPARQLproject.Models;
using SPARQLproject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPARQLproject
{
    public partial class Form1 : Form
    {
        private BookService bookService;
        private FilmService filmService;
        public Form1()
        {
            InitializeComponent();
            AuthorizeGoodreads();
            rbSearchByBookName.Checked = true;
            bsBooks.DataSource = new List<BookModel>();
            bsFilms.DataSource = new List<FilmModel>();
        }

        private void AuthorizeGoodreads()
        {
            bookService = new BookService();
            filmService = new FilmService();

        }

        private void btnSumbitAccount_Click(object sender, EventArgs e)
        {
            if (long.TryParse(txtUserId.Text, out long userId))
            {
                var books= bookService.GetUserBooks(userId);
                bsBooks.DataSource = books;
            }
            else
            {
                MessageBox.Show("user id should long int");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var books = (List<BookModel>)bsBooks.DataSource;
            if (books.Any(x => x.IsSelected))
            {
                if (rbSearchByBookName.Checked)
                {
                    bsFilms.DataSource = filmService.GetFilmsByBookName(books.Where(x => x.IsSelected).Select(x => x.Name).ToList());
                }
                else if (rbSearchByBookAuthor.Checked)
                {
                    bsFilms.DataSource = filmService.GetFilmsByBookAuthor(books.Where(x => x.IsSelected).Select(x => x.Author).ToList());
                }
            }
            else
            {
                MessageBox.Show("select at least one book");
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            var books = (List<BookModel>)bsBooks.DataSource;
            books = books.Select(x => new BookModel() { Id = x.Id,Name=x.Name, Author=x.Author, IsSelected = true }).ToList();
            bsBooks.DataSource = books;
        }
    }
}
