import 'devextreme/dist/css/dx.light.css';
import React, { Component } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { Layout } from './components/Layout';
import './custom.css';
import 'devextreme/dist/css/dx.light.css';
import { 
  Button,
  DataGrid,
  GridColumn as Column
} from "./devextreme-bundle/devextreme-react-bundle";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Layout>
        <Routes>
          {AppRoutes.map((route, index) => {
            const { element, ...rest } = route;
            return <Route key={index} {...rest} element={element} />;
          })}
        </Routes>
      </Layout>
    );
  }
}
