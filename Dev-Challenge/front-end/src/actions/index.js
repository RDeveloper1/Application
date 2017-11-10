import fetch from 'isomorphic-fetch'

export function loadMongoData(data) {
    console.log(data);
  return {
    type: 'LOAD_DATA',
    data
  }
}

export function fetchData(query) {
  return dispatch => {
    fetch(`http://localhost:54238/api/search/${query}`)
      .then(response => response.json())
      .then(data => dispatch(loadMongoData(data)))
      .catch(error => console.log(error))
  }
}