import * as React from 'react';
import { Grid, AppBar, Toolbar } from 'material-ui';
import { BrowserRouter as Router, Route, Link } from 'react-router-dom';
import { CounterContainer } from './Counter/CounterContainer';
import Reviews from "../components/reviews/reviewsView";

/** Used for passing sidebar, header, and main formatted content. */
export interface MainPageProperties {
    sidebar: React.ReactNode;
    header: React.ReactNode;
    main: React.ReactNode;
}

/** A simple predefined layout with a header, sidebar, and main body. */
export class MainPage extends React.PureComponent<MainPageProperties> {
  render(): React.ReactNode {
     return (
        <div id="main">

            <Router>
                <div>
            <AppBar position="static">
                <Toolbar>
                        <ul>
                            <li>
                            <Link to="/home">Home</Link>
                            </li>
                            <li>
                            <Link to="/about">About</Link>
                            </li>
                            <li>
                            <Link to="/topics">Topics</Link>
                            </li>
                        </ul>

                                    
                </Toolbar>
            </AppBar>
            
            <Grid container spacing={8}>
                <Grid item xs={2}>
                    {this.props.sidebar}
                </Grid>
                <Grid item xs={10}>
                <Route path="/home" render={ props => <Reviews {...props} /> }/>
                        <Route path="/review/:id" render={ props => <CounterContainer {...props} /> }/>

                </Grid>        
            </Grid>
            </div>
            </Router>
        </div>
      );
  }
}
