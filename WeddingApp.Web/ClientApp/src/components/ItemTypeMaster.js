import React, { Component } from "react";

export class ItemTypeMaster extends Component {
  static displayName = ItemTypeMaster.name;

  constructor(props) {
    super(props);
    this.state = { itemType: [], loading: true };
  }
  //   ComponentDidMount() {
  //     this.renderItemType();
  //   }
  render() {
    return (
      <div className="card">
        <div className="card-body">
          <h2>Master Item Type</h2>
          <p>This is using Props</p>
        </div>
      </div>
    );
  }
}
