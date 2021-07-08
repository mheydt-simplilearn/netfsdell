import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Medicines } from './components/Medicines';
import { Cart } from './components/Cart';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
            <Route exact path='/' component={Medicines} />
            <Route exact path='/cart/:id' component={Cart} />
      </Layout>
    );
  }
}
