import React, { Component } from 'react';

import { Link } from 'react-router-dom';
import { Button } from 'reactstrap';


export class Cart extends Component {
  static displayName = Cart.name;

  constructor(props) {
    super(props);
    this.state = { items: [], loading: true };
  }

  componentDidMount() {
    this.populateCartItems();
  }

  static renderCartTable(items) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Id</th>
            <th>CategoryId</th>
            <th>Name</th>
            <th>Description</th>
            <th>Price</th>
            <th>Image</th>
            <th>Seller</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {items.map(medicine =>
              <tr key={medicine.id}>
                <td>{medicine.id}</td>
                <td>{medicine.categoryId}</td>
                <td>{medicine.name}</td>
                <td>{medicine.description}</td>
                <td>{medicine.price}</td>
                <td>{medicine.image}</td>
                  <td>{medicine.seller}</td>
                  <td>

                      <Button
                          color="primary"

                      >Buy</Button>
                  </td>
              </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Cart.renderCartTable(this.state.items);

    return (
      <div>
        <h1 id="tabelLabel" >Shopping Cart</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateCartItems() {
    const response = await fetch('api/cart');
    const data = await response.json();
    this.setState({ items: data, loading: false });
  }
}
