import { combineReducers } from 'redux'

const apiData = (state = [], action) => {
  switch(action.type) {
    case "LOAD_DATA": 
      return state = action.data;
    default: 
      return state
  }
}

const rootReducer = combineReducers({
  apiData: apiData,
})

export default rootReducer