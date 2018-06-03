import React, { Component } from "react";
//import SingleLineReview from '../singleLineReview/singleLineReviewView';
import { connect } from "react-redux";
import { Grid, Row, Col, Button } from "react-bootstrap";
// import { fetchItemsData } from '../../actions/items';

class Reviews extends Component<any, any> {
  constructor() {
    super(0);
    // this.addNewReview = this.handleAddReview.bind(this);
  }

  handleAddReview() {
    this.props.history.push("/review/newReview");
  }

  render() {
    const gridInstance = (
      <div>
        <Grid>
          <Row className="show-grid container">
            <Col xs={12} md={12}>
              Reviews. Enjoy putting reviews here about anything and everything
            </Col>
            <Col xs={8} md={12}>
              {/* <Button onClick={this.addNewReview}>Add new Review</Button> */}
              <Button>Add new Review</Button>
            </Col>
            {/* {this.props.items.map((review) => {
                      let props = {
                        key: review.id,
                        id: review.id,
                        topic: review.topic,
                        numberOfViews: review.numberOfViews,
                        lastUpdated: review.lastUpdated
                      }
                  return <SingleLineReview {...props}/>;
            })} */}
          </Row>
        </Grid>

        <p className="App-intro">
          To get started, start getting expressed here.
        </p>
      </div>
    );
    return gridInstance;
  }

  componentWillMount() {
    //this.props.fetchData('http://localhost:3002/api/reviews');
  }
}

const mapStateToProps = state => {
  return {
    items: state.items
  };
};

const mapDispatchToProps = () => {
  return {
    // fetchData: (url) => dispatch(fetchItemsData(url))
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(Reviews);
