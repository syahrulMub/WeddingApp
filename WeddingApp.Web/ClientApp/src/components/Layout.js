import React, { Component } from "react";
import { Container } from "reactstrap";
import { NavMenu } from "./NavMenu";
import MenuSideBar from "./Menu/MenuSideBar";

export class Layout extends Component {
  static displayName = Layout.name;

  render() {
    return (
      <div className="menu-container">
        <div className="main-container">
          <NavMenu />
          <Container tag="main">{this.props.children}</Container>
        </div>
      </div>
    );
  }
}
