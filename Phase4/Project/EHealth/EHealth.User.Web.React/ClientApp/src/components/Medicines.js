import React, { Component } from 'react';
import { Button } from 'reactstrap';
import { Link } from 'react-router-dom';
import { useHistory } from 'react-router-dom';
import { withRouter } from 'react-router-dom'

export class Medicines extends Component {
  static displayName = Medicines.name;

  constructor(props) {
    super(props);
    this.state = { medicines: [], loading: true };
  }

  componentDidMount() {
    this.populateMedicines();
  }

  static renderMedicinesTable(medicines) {
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
          {medicines.map(medicine =>
              <tr key={medicine.id}>
                <td>{medicine.id}</td>
                <td>{medicine.categoryId}</td>
                <td>{medicine.name}</td>
                <td>{medicine.description}</td>
                <td>{medicine.price}</td>
                  <td>{medicine.image}</td>
                  
                  <td>{medicine.seller}</td>
                  <td>
                      <Link to="/cart" className="btn btn-primary" params={{ id: medicine.id }}>Buy</Link>

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
      : Medicines.renderMedicinesTable(this.state.medicines);

    return (
      <div>
        <h1 id="tabelLabel" >Medicines</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateMedicines() {
    const response = await fetch('api/medicines');
    const data = await response.json();
    this.setState({ medicines: data, loading: false });
  }
}


