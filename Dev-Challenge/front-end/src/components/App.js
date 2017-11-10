import React, { Component } from 'react';
import { connect } from 'react-redux';
import TableRow from './TableRow';
import Collapsible from 'react-collapsible';
import { fetchData } from '../actions';

class App extends Component {

	constructor(){
      super();
      this.state = {
        value: ''
      }
			this.handleSubmit = this.handleSubmit.bind(this);
			this.handleChange = this.handleChange.bind(this);
	};

  handleChange(event) {
    this.setState({value: event.target.value})
  }
  
  handleSubmit(event) {
    event.preventDefault();
    if(this.state.value === '') return;
    this.props.fetchData(this.state.value);
    this.setState({value: ''});
  }
  
	render() {
		return (
      <div>
        <nav>
          <div className="navbar">
            Dev-Challenge
          </div>
        </nav>
			<div className="container">
					<form onSubmit={this.handleSubmit}>
							<div className="row">
								<div className="form-group">
									<div className="col-xs-6 col-md-4">
											<input type="text" value={this.state.value} onChange={this.handleChange} ref="query" className="form-control" placeholder="Enter Title"/>   
									</div>
									<div className="col-xs-6 col-md-8">
											<input type="submit" value="Search" className="btn btn-success"/>
									</div>
								</div>
							</div> 
							<h4 className="text-uppercase">
								{this.props.apiData.map((dynamicData, i) => <TableRow key = {i} data = {dynamicData} />)} 
							</h4> 
					</form>
				</div>
      </div>
		);
	}
}

// Mapping apiData from Redux store to apiData as props
const mapStateToProps = (state) => {
  return {
    apiData: state.apiData
  }
}


const mapDispatchToProps = (dispatch, ownProps) => {
  return { 
    fetchData: (query) => { dispatch(fetchData(query)) }
  }
}

export default connect(mapStateToProps, mapDispatchToProps)(App)

