import React from 'react';
import { BrowserRouter, Switch, Route, Link } from "react-router-dom";
import { CounterContainer }  from "../components/Counter/CounterContainer";

class Router extends React.PureComponent {
  render(){
  return (
    <BrowserRouter>
      <div>
        <Link to="/home">Home</Link>
        <Link to="/review/:id">Add Review</Link>
        <Switch>
          <Route path="/home" render={ props => <CounterContainer {...props} /> }/>
        </Switch>
        </div>
    </BrowserRouter>
  );
  }
} 

export default Router;