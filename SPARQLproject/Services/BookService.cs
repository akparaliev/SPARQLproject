using Goodreads;
using Goodreads.Models.Response;
using SPARQLproject.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPARQLproject.Services
{
    public class BookService
    {
        private IOAuthGoodreadsClient _authClient;
        public BookService()
        {
            //get goodread developer key and developer secret key
            var appSettings = ConfigurationManager.AppSettings;
            var GOODREADS_KEY = appSettings.Get("GOODREADSKEY");
            var GOODREADS_SECRET = appSettings.Get("GOODREADSSECRET");

            //connect a client
            var client = GoodreadsClient.Create(GOODREADS_KEY, GOODREADS_SECRET);
            const string callbackUrl = "<no-callback>";
            var requestToken = client.AskCredentials(callbackUrl).GetAwaiter().GetResult();
            var accessToken = client.GetAccessToken(requestToken).GetAwaiter().GetResult();
            _authClient = GoodreadsClient.CreateAuth(GOODREADS_KEY, GOODREADS_SECRET, accessToken.Token, accessToken.Secret);
        }
        private void Auth()
        {
          
        }
        public List<BookModel> GetUserBooks(long userId)
        {
            var allBooks = new List<Review>();
            var books = new PaginatedList<Review>();
            int page = 1;
            do
            {
                books = _authClient.Reviews.GetListByUser(userId,page: page).GetAwaiter().GetResult();
                if (books.List == null) break;
                allBooks.AddRange(books.List);
                page++;
                Thread.Sleep(1000); //api of goodreads require 1sec delay
            } while (true);
            if (allBooks.Count ==0)
            {
                MessageBox.Show("current user does not have books");
            }

            var pageBookModel = 
             allBooks.Select(x =>
                        new BookModel()
                        { Name = FormatString(x.Book.Title),
                            Author = x.Book.Authors.Any()?x.Book.Authors[0].Name:"",
                            Id = x.Book.Id }).ToList();
            return pageBookModel;
        }
        private string FormatString(string input)
        {
            var patternToDeleteBrackets = @"\((.*?)\)|\{(.*?)\}|\""(.*?)\""|\'(.*?)\'";
            var output = Regex.Replace(input, patternToDeleteBrackets, "").Replace("'","");
            
            return output.Trim();
        }
    }
}
