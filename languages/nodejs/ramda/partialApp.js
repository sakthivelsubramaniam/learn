const R = require('ramda');

const movies = [
  {
    title: "Tomorrow Never Dies",
		  ReleaseYear : 1994,
    Gender : 'Games Bond',
  },
  {
    title: "Back to the future",
		 ReleaseYear : 1983,
    Gender : "Science Fiction",
  },
  {
    title: "Casino",
		 ReleaseYear : 1999,
    Gender : "Drama"
  },
  {
    title: "Cassenova",
		  ReleaseYear : 1989,
    Gender : "Comody",
  },
  {
    title: "Tommorrows war",
		  ReleaseYear : 2021,
    Gender : "Science Fiction",
  },
]

const ReleasedInYear =  (movie, year) => movie.ReleaseYear === year

const titlesForYear = (movies, year) => {

  const selected = R.filter(movie => ReleasedInYear(movie, year), movies)
  return R.map(movie => movie.title, selected)
}

const result = titlesForYear (movies, 2021)
console.log(result)