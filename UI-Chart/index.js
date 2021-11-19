import React from 'react';
import { render } from 'react-dom';
import Chart from './Chart';
import { getData } from "./utils"
//import * as serviceWorker from './serviceWorker';


class ChartComponent extends React.Component {

    constructor() {
        super();
    }

    componentDidMount() {
        getData().then(data => {
            this.setState({ data })
            //this.setState({ data: data }); // use this to append data ?
		})
    }

    render() {
        if (this.state == null) {
			return <div>Loading...</div>
        }
        return <Chart type="hybrid" data={this.state.data} />
	}
}


render(
	<ChartComponent />,
	document.getElementById("root")
);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: http://bit.ly/CRA-PWA
//serviceWorker.unregister();
