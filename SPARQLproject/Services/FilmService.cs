
using SPARQLproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Query;
using VDS.RDF.Storage;

namespace SPARQLproject.Services
{
    public class FilmService
    {

        public List<FilmModel> GetFilmsByBookName(List<string> booksName)
        {
            var filtQ = GetFilteredQuery(booksName, "?basedOnBookLabel");
            var query = "SELECT distinct ?filmLabel (year(?date) as ?year) ?countryLabel ?genreLabel ?basedOnBookLabel WHERE { " +
                   "?film wdt:P31 wd:Q11424. " +
                   "?film wdt:P144  ?basedOnBook. " +
                   "?basedOnBook wdt:P31 wd:Q571. " +
                   "?film wdt:P1476 ?filmLabel. " +
                   "?basedOnBook rdfs:label ?basedOnBookLabel filter (lang(?basedOnBookLabel) = 'en') " +
                   "Optional {?film wdt:P577 ?date.} " +
                   "Optional {?film wdt:P495 ?country. " +
                        "?country rdfs:label ?countryLabel filter (lang(?countryLabel) = 'en' ).} " +
                   "Optional {?film wdt:P136 ?genre. " +
                        "?genre rdfs:label ?genreLabel filter (lang(?genreLabel) = 'en' ).} " +
            $"{filtQ}" + "}";
            return ReturnListOfFilms(query);
        }

        public List<FilmModel> GetFilmsByBookAuthor(List<string> books)
        {
            var filtQ = GetFilteredQuery(books, "?bookAuthorLabel");
            var query = "SELECT distinct ?filmLabel (year(?date) as ?year) ?countryLabel ?genreLabel ?bookAuthorLabel WHERE { " +
                   "?film wdt:P31 wd:Q11424. " +
                   "?film wdt:P144  ?basedOnBook. " +
                   "?basedOnBook wdt:P31 wd:Q571. " +
                   "?film wdt:P1476 ?filmLabel. " +
                   "?basedOnBook wdt:P50 ?bookAuthor." +
                   "?bookAuthor rdfs:label ?bookAuthorLabel filter(lang(?bookAuthorLabel) = 'en'). " +
                   "Optional {?film wdt:P577 ?date.} " +
                   "Optional {?film wdt:P495 ?country. " +
                        "?country rdfs:label ?countryLabel filter (lang(?countryLabel) = 'en' ).} " +
                   "Optional {?film wdt:P136 ?genre. " +
                        "?genre rdfs:label ?genreLabel filter (lang(?genreLabel) = 'en' ).} " +
            $"{filtQ}" + "}";
            return ReturnListOfFilms(query);
        }

        private List<FilmModel> ReturnListOfFilms(string query)
        {
            //First we need an instance of the SparqlQueryParser
            var uri = new Uri("https://query.wikidata.org/sparql");
            var endpoint = new SparqlRemoteEndpoint(uri);
            var films = new List<FilmModel>();
    
            SparqlResultSet results = endpoint.QueryWithResultSet(query);
            foreach (SparqlResult result in results)
            {
                films.Add(new FilmModel()
                {
                    Name = ((ILiteralNode)result[0]).Value,
                    Year = ((ILiteralNode)result[1]).Value,
                    Country = ((ILiteralNode)result[2]).Value,
                    Genre = ((ILiteralNode)result[3]).Value,
                    SearchParam = ((ILiteralNode)result[4]).Value
                });
            }

            return films;
        }
     
        private StringBuilder GetFilteredQuery(List<string> filterList,string regexInput)
        {
            var resultFilter = new StringBuilder("Filter (");
            for (int i = 0; i < filterList.Count;i++)
            {
                resultFilter.Append($"regex(str({regexInput}), '{filterList[i]}')");
                if (i != filterList.Count - 1)
                {
                    resultFilter.Append(" || ");
                }
            }
            resultFilter.Append(")");
            return resultFilter;
        }

    }
}
