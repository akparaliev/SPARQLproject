# SPARQLproject
### Description
 - desktop project to find films with book's name or author from Goodreads account
 - runs only in Windows
 - requires the internet connection
## User Guide
- run SPARQLproject.exe in bin/Debug folder
- application can require .NET Framework library (v. >= 4.7.1)
- type goodreads.com account id (59267749 - by default)
- to view books of this account press "Submit user" button
- in datagrid of books select books to search or press "Select all" button to select all books
- select search type in field "Choose a search type" (by Book Name option is default)
- press "Search movies"

## Developer Guide
### Technologies and packages:
- WinForms .NET
- dotNetRDF
- Goodreads .NET API client

### Architecture
- application has one form with buttons, datagrids, textbooks and radiobuttons
- there are two service classes: BookService and FilmService

#### BookService 
  - works with Goodreads API
  - authorize developer with GOODREADSKEY and GOODREADSSECRET keys, this keys are stored in App.config
  - return books by user id(method: GetUserBooks);

#### FilmService 
  - works with dotNetRDF
  - takes author names(method: GetFilmsByBookAuthor) or book names(method: GetFilmsByBookName), make sparql request and return Films that are based on books with this author names or books names

## Sparql
### Endpoint
- application uses only https://query.wikidata.org/sparql endpoint
### simple query to find films with book names
```
SELECT distinct ?filmLabel (year(?date) as ?year) ?countryLabel  ?genreLabel ?basedOnBookLabel WHERE {
  ?film wdt:P31 wd:Q11424.
  ?film wdt:P144 ?basedOnBook.
  ?basedOnBook wdt:P31 wd:Q571.
  ?film wdt:P1476 ?filmLabel.
  ?basedOnBook rdfs:label ?basedOnBookLabel filter (lang(?basedOnBookLabel) = "en").
  Optional {?film wdt:P577 ?date.
           }
  Optional {?film wdt:P495 ?country.
           ?country rdfs:label ?countryLabel filter (lang(?countryLabel) = "en" ).
           }
  Optional {?film wdt:P136 ?genre.
            ?genre rdfs:label ?genreLabel filter (lang(?genreLabel) = "en" ).
           }
  Filter (regex(str(?basedOnBookLabel), 'Harry Potter')).
}
```
#### where: 
- Items: 
  - film (Q11424), 
  - book (Q571) 
  - (see detail information: https://www.wikidata.org/wiki/Q571, where Q571 is an item)
- Properties: 
  - instance of (P31),
  - based on (P144),
  - title (P1476), 
  - label (item label), 
  - publication date (P577), 
  - country of origin (P495), 
  - genre (P136)  
  - (see detail information: https://www.wikidata.org/wiki/Property:P136 , where P136 is property code)


### simple query to find films with book author names

```
SELECT distinct ?filmLabel (year(?date) as ?year) ?countryLabel  ?genreLabel ?bookAuthorLabel WHERE {
  ?film wdt:P31 wd:Q11424.
  ?film wdt:P144 ?basedOnBook.
  ?basedOnBook wdt:P31 wd:Q571.
  ?film wdt:P1476 ?filmLabel.
  ?basedOnBook wdt:P50 ?bookAuthor.
  ?bookAuthor rdfs:label ?bookAuthorLabel filter (lang(?bookAuthorLabel) = "en" ).
  Optional {?film wdt:P577 ?date.
           }
  Optional {?film wdt:P495 ?country.
           ?country rdfs:label ?countryLabel filter (lang(?countryLabel) = "en" ).
           }
  Optional {?film wdt:P136 ?genre.
            ?genre rdfs:label ?genreLabel filter (lang(?genreLabel) = "en" ).
           }
  Filter (regex(str(?bookAuthorLabel), 'Haruki Murakami'))
}
```
#### where: 
- Items: 
  - film (Q11424), 
  - book (Q571) 
  - (see detail information: https://www.wikidata.org/wiki/Q571, where Q571 is an item)
- Properties: 
  - instance of (P31),
  - based on (P144),
  - title (P1476), 
  - author (P50),
  - label (item label), 
  - publication date (P577), 
  - country of origin (P495), 
  - genre (P136)  
  - (see detail information: https://www.wikidata.org/wiki/Property:P136 , where P136 is property code)




