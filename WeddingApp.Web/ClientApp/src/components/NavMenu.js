import React, { Component } from "react";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {
  faHome,
  faCalendar,
  faDatabase,
  faAnchorLock,
} from "@fortawesome/free-solid-svg-icons";
import {
  Collapse,
  Navbar,
  NavbarBrand,
  NavbarToggler,
  NavItem,
  NavLink,
} from "reactstrap";
import { Link } from "react-router-dom";
import "./NavMenu.css";

export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor(props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true,
    };
  }

  toggleNavbar() {
    this.setState({
      collapsed: !this.state.collapsed,
    });
  }

  render() {
    return (
      <header>
        <Navbar
          className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3"
          container
          light
        >
          <NavbarBrand tag={Link} to="/">
            Wedding Program
          </NavbarBrand>
          <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
          <Collapse
            className="d-sm-inline-flex flex-sm-row-reverse"
            isOpen={!this.state.collapsed}
            navbar
          >
            <ul className="navbar-nav flex-grow">
              <NavItem>
                <NavLink tag={Link} className="text-dark " to="/">
                  <FontAwesomeIcon
                    icon={faHome}
                    className="pr-2 text-green-300"
                  />
                  Home
                </NavLink>
              </NavItem>
              <NavItem>
                <NavLink tag={Link} className="text-dark" to="/counter">
                  <FontAwesomeIcon
                    icon={faCalendar}
                    className="pr-2 text-red-400"
                  />
                  Counter
                </NavLink>
              </NavItem>
              <NavItem>
                <NavLink tag={Link} className="text-dark" to="/fetch-data">
                  <FontAwesomeIcon
                    icon={faDatabase}
                    className="pr-2 text-blue-400"
                  />
                  Fetch data
                </NavLink>
              </NavItem>
              <NavItem>
                <NavLink tag={Link} className="text-dark" to="/item-type">
                  <FontAwesomeIcon
                    icon={faAnchorLock}
                    className="pr-2 text-gray-600"
                  />
                  Item Type
                </NavLink>
              </NavItem>
              <NavItem>
                <NavLink tag={Link} className="text-dark" to="/training">
                  <FontAwesomeIcon
                    icon={faAnchorLock}
                    className="pr-2 text-gray-600"
                  />
                  Training React
                </NavLink>
              </NavItem>
            </ul>
          </Collapse>
        </Navbar>
      </header>
    );
  }
}
