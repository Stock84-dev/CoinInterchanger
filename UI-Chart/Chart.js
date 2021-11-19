//import React from "react";
//import PropTypes from "prop-types";

//import { format } from "d3-format";
//import { timeFormat } from "d3-time-format";

//import { ChartCanvas, Chart, ZoomButtons } from "react-stockcharts";
//import {
//    BarSeries,
//    CandlestickSeries,
//    AreaSeries,
//    LineSeries,
//    MACDSeries,
//} from "react-stockcharts/lib/series";
//import { XAxis, YAxis } from "react-stockcharts/lib/axes";
//import {
//    CrossHairCursor,
//    EdgeIndicator,
//    CurrentCoordinate,
//    MouseCoordinateX,
//    MouseCoordinateY,
//} from "react-stockcharts/lib/coordinates";

//import { discontinuousTimeScaleProviderBuilder } from "react-stockcharts/lib/scale";
//import { discontinuousTimeScaleProvider } from "react-stockcharts/lib/scale";
//import {
//    OHLCTooltip,
//    MovingAverageTooltip,
//    MACDTooltip,
//} from "react-stockcharts/lib/tooltip";
//import { fitWidth } from "react-stockcharts/lib/helper";
//import { last } from "react-stockcharts/lib/utils";
//import { ema, sma, macd } from "react-stockcharts/lib/indicator";

//function getMaxUndefined(calculators) {
//    return calculators.map(each => each.undefinedLength()).reduce((a, b) => Math.max(a, b));
//}
//const LENGTH_TO_SHOW = 180;

//const macdAppearance = {
//    stroke: {
//        macd: "#FF0000",
//        signal: "#00F300",
//    },
//    fill: {
//        divergence: "#4682B4"
//    },
//};

//class CandleStickChartWithZoomPan extends React.Component {
//    constructor(props) {
//        super(props);
//        this.saveNode = this.saveNode.bind(this);
//        this.resetYDomain = this.resetYDomain.bind(this);
//        this.handleReset = this.handleReset.bind(this);

//        const { data: inputData } = props;

//        const ema26 = ema()
//            .id(0)
//            .options({ windowSize: 26 })
//            .merge((d, c) => { d.ema26 = c; })
//            .accessor(d => d.ema26);

//        const ema12 = ema()
//            .id(1)
//            .options({ windowSize: 12 })
//            .merge((d, c) => { d.ema12 = c; })
//            .accessor(d => d.ema12);

//        const macdCalculator = macd()
//            .options({
//                fast: 12,
//                slow: 26,
//                signal: 9,
//            })
//            .merge((d, c) => { d.macd = c; })
//            .accessor(d => d.macd);

//        const smaVolume50 = sma()
//            .id(3)
//            .options({
//                windowSize: 50,
//                sourcePath: "volume",
//            })
//            .merge((d, c) => { d.smaVolume50 = c; })
//            .accessor(d => d.smaVolume50);

//        const maxWindowSize = getMaxUndefined([ema26,
//            ema12,
//            macdCalculator,
//            smaVolume50
//        ]);
//        /* SERVER - START */
//        const dataToCalculate = inputData.slice(-LENGTH_TO_SHOW - maxWindowSize);

//        const calculatedData = ema26(ema12(macdCalculator(smaVolume50(dataToCalculate))));
//        const indexCalculator = discontinuousTimeScaleProviderBuilder().indexCalculator();

//        // console.log(inputData.length, dataToCalculate.length, maxWindowSize)
//        const { index } = indexCalculator(calculatedData);
//        /* SERVER - END */

//        const xScaleProvider = discontinuousTimeScaleProviderBuilder()
//            .withIndex(index);
//        const { data: linearData, xScale, xAccessor, displayXAccessor } = xScaleProvider(calculatedData.slice(-LENGTH_TO_SHOW));

//        // console.log(head(linearData), last(linearData))
//        // console.log(linearData.length)

//        this.state = {
//            ema26,
//            ema12,
//            macdCalculator,
//            smaVolume50,
//            linearData,
//            data: linearData,
//            xScale,
//            xAccessor, displayXAccessor
//        };
//        this.handleDownloadMore = this.handleDownloadMore.bind(this);
//    }
//    componentWillMount() {
//        this.setState({
//            suffix: 1
//        });
//    }
//    saveNode(node) {
//        this.node = node;
//    }
//    resetYDomain() {
//        this.node.resetYDomain();
//    }
//    handleReset() {
//        this.setState({
//            suffix: this.state.suffix + 1
//        });
//    }

//    handleDownloadMore(start, end) {
//        if (Math.ceil(start) === end) return;
//        // console.log("rows to download", rowsToDownload, start, end)
//        const { data: prevData, ema26, ema12, macdCalculator, smaVolume50 } = this.state;
//        const { data: inputData } = this.props;


//        if (inputData.length === prevData.length) return;

//        const rowsToDownload = end - Math.ceil(start);

//        const maxWindowSize = getMaxUndefined([ema26,
//            ema12,
//            macdCalculator,
//            smaVolume50
//        ]);

//        /* SERVER - START */
//        const dataToCalculate = inputData
//            .slice(-rowsToDownload - maxWindowSize - prevData.length, - prevData.length);

//        const calculatedData = ema26(ema12(macdCalculator(smaVolume50(dataToCalculate))));
//        const indexCalculator = discontinuousTimeScaleProviderBuilder()
//            .initialIndex(Math.ceil(start))
//            .indexCalculator();
//        const { index } = indexCalculator(
//            calculatedData
//                .slice(-rowsToDownload)
//                .concat(prevData));
//        /* SERVER - END */

//        const xScaleProvider = discontinuousTimeScaleProviderBuilder()
//            .initialIndex(Math.ceil(start))
//            .withIndex(index);

//        const { data: linearData, xScale, xAccessor, displayXAccessor } = xScaleProvider(calculatedData.slice(-rowsToDownload).concat(prevData));

//        // console.log(linearData.length)
//        setTimeout(() => {
//            // simulate a lag for ajax
//            this.setState({
//                data: linearData,
//                xScale,
//                xAccessor,
//                displayXAccessor,
//            });
//        }, 300);
//    }

//    render() {
//        const { type, width, ratio } = this.props;
//        const { mouseMoveEvent, panEvent, zoomEvent, zoomAnchor } = this.props;
//        const { ema26, ema12, macdCalculator, smaVolume50 } = this.state;
//        const { clamp } = this.props;

//        const { data: initialData } = this.props;

//        const xScaleProvider = discontinuousTimeScaleProvider
//            .inputDateAccessor(d => d.date);
//        const {
//            data,
//            xScale,
//            xAccessor,
//            displayXAccessor,
//        } = xScaleProvider(initialData);

//        const start = xAccessor(last(data));
//        const end = xAccessor(data[Math.max(0, data.length - 150)]);
//        const xExtents = [start, end];

//        const margin = { left: 70, right: 70, top: 10, bottom: 30 };

//        const height = 400;

//        const gridHeight = height - margin.top - margin.bottom;
//        const gridWidth = width - margin.left - margin.right;

//        const showGrid = true;
//        const yGrid = showGrid ? { innerTickSize: -1 * gridWidth, tickStrokeOpacity: 0.2 } : {};
//        const xGrid = showGrid ? { innerTickSize: -1 * gridHeight, tickStrokeOpacity: 0.2 } : {};

//        return (
//            <ChartCanvas ref={this.saveNode} height={height}
//                ratio={ratio}
//                width={width}
//                margin={margin}
//                onLoadMore={this.handleDownloadMore}
//                mouseMoveEvent={mouseMoveEvent}
//                panEvent={panEvent}
//                zoomEvent={zoomEvent}
//                clamp={clamp}
//                zoomAnchor={zoomAnchor}
//                type={type}
//                seriesName={`MSFT_${this.state.suffix}`}
//                data={data}
//                xScale={xScale}
//                xExtents={xExtents}
//                xAccessor={xAccessor}
//                displayXAccessor={displayXAccessor}
//            >

//                <Chart id={1}
//                    yExtents={[d => [d.high, d.low], ema26.accessor(), ema12.accessor()]}
//                    padding={{ top: 10, bottom: 20 }}>
//                    <XAxis axisAt="bottom" orient="bottom" zoomEnabled={zoomEvent} showTicks={false} outerTickSize={0} />
//                    <YAxis axisAt="right" orient="right" zoomEnabled={zoomEvent} ticks={5} />

//                    <MouseCoordinateY
//                        at="right"
//                        orient="right"
//                        displayFormat={format(".2f")} />

//                    <CandlestickSeries />
//                    <LineSeries yAccessor={ema26.accessor()} stroke={ema26.stroke()} />
//                    <LineSeries yAccessor={ema12.accessor()} stroke={ema12.stroke()} />

//                    <CurrentCoordinate yAccessor={ema26.accessor()} fill={ema26.stroke()} />
//                    <CurrentCoordinate yAccessor={ema12.accessor()} fill={ema12.stroke()} />

//                    <EdgeIndicator itemType="last" orient="right" edgeAt="right"
//                        yAccessor={d => d.close} fill={d => d.close > d.open ? "#6BA583" : "#FF0000"} />

//                    <OHLCTooltip origin={[-40, 0]} />
//                    <ZoomButtons
//                        onReset={this.handleReset}
//                    />
//                    <MovingAverageTooltip
//                        onClick={(e) => console.log(e)}
//                        origin={[-38, 15]}
//                        options={[
//                            {
//                                yAccessor: ema26.accessor(),
//                                type: ema26.type(),
//                                stroke: ema26.stroke(),
//                                ...ema26.options(),
//                            },
//                            {
//                                yAccessor: ema12.accessor(),
//                                type: ema12.type(),
//                                stroke: ema12.stroke(),
//                                ...ema12.options(),
//                            },
//                        ]}
//                    />
//                </Chart>
//                {/* volume */}
//                <Chart id={2} height={150}
//                    yExtents={[d => d.volume, smaVolume50.accessor()]}
//                    origin={(w, h) => [0, h - 150]}>
//                    <YAxis axisAt="left" orient="left" zoomEnabled={zoomEvent} ticks={5} tickFormat={format(".2s")} />

//                    <MouseCoordinateY
//                        at="left"
//                        orient="left"
//                        displayFormat={format(".4s")} />

//                    <BarSeries yAccessor={d => d.volume} fill={d => d.close > d.open ? "#6BA583" : "#FF0000"} />
//                    <AreaSeries yAccessor={smaVolume50.accessor()} stroke={smaVolume50.stroke()} fill={smaVolume50.fill()} />
//                </Chart>
//                <CrossHairCursor />
//            </ChartCanvas>
//        );
//    }
//}

//CandleStickChartWithZoomPan.propTypes = {
//    data: PropTypes.array.isRequired,
//    width: PropTypes.number.isRequired,
//    ratio: PropTypes.number.isRequired,
//    type: PropTypes.oneOf(["svg", "hybrid"]).isRequired,
//};

//CandleStickChartWithZoomPan.defaultProps = {
//    type: "svg",
//    mouseMoveEvent: true,
//    panEvent: true,
//    zoomEvent: true,
//    clamp: false,
//};

//CandleStickChartWithZoomPan = fitWidth(CandleStickChartWithZoomPan);

//export default CandleStickChartWithZoomPan;



// TODO: chart rescales only on first click
import { format } from "d3-format";
import { timeFormat } from "d3-time-format";

import React from "react";
import PropTypes from "prop-types";

import { ChartCanvas, Chart, ZoomButtons } from "react-stockcharts";
import {
    BarSeries,
    AreaSeries,
    CandlestickSeries,
} from "react-stockcharts/lib/series";
import { XAxis, YAxis } from "react-stockcharts/lib/axes";
import {
    CrossHairCursor,
    EdgeIndicator,
    MouseCoordinateX,
    MouseCoordinateY,
} from "react-stockcharts/lib/coordinates";

import { discontinuousTimeScaleProviderBuilder } from "react-stockcharts/lib/scale";
import { OHLCTooltip, MovingAverageTooltip, MACDTooltip } from "react-stockcharts/lib/tooltip";
import { ema, sma, macd } from "react-stockcharts/lib/indicator";
import { fitWidth } from "react-stockcharts/lib/helper";
import { last } from "react-stockcharts/lib/utils";

function getMaxUndefined(calculators) {
    return calculators.map(each => each.undefinedLength()).reduce((a, b) => Math.max(a, b));
}
const LENGTH_TO_SHOW = 180;

class CandleStickChartPanToLoadMore extends React.Component {
    constructor(props) {
        super(props);
        // preparation to reset chart
        this.saveNode = this.saveNode.bind(this);
        this.resetYDomain = this.resetYDomain.bind(this);
        this.handleReset = this.handleReset.bind(this);

        const { data: inputData } = props;

        const ema26 = ema()
            .id(0)
            .options({ windowSize: 26 })
            .merge((d, c) => { d.ema26 = c; })
            .accessor(d => d.ema26);

        const ema12 = ema()
            .id(1)
            .options({ windowSize: 12 })
            .merge((d, c) => { d.ema12 = c; })
            .accessor(d => d.ema12);

        const macdCalculator = macd()
            .options({
                fast: 12,
                slow: 26,
                signal: 9,
            })
            .merge((d, c) => { d.macd = c; })
            .accessor(d => d.macd);

        const smaVolume50 = sma()
            .id(3)
            .options({
                windowSize: 50,
                sourcePath: "volume",
            })
            .merge((d, c) => { d.smaVolume50 = c; })
            .accessor(d => d.smaVolume50);

        const maxWindowSize = getMaxUndefined([ema26,
            ema12,
            macdCalculator,
            smaVolume50
        ]);
        /* SERVER - START */
        const dataToCalculate = inputData.slice(-LENGTH_TO_SHOW - maxWindowSize);

        const calculatedData = ema26(ema12(macdCalculator(smaVolume50(dataToCalculate))));
        const indexCalculator = discontinuousTimeScaleProviderBuilder().indexCalculator();

        // console.log(inputData.length, dataToCalculate.length, maxWindowSize)
        const { index } = indexCalculator(calculatedData);
        /* SERVER - END */

        const xScaleProvider = discontinuousTimeScaleProviderBuilder()
            .withIndex(index);
        const { data: linearData, xScale, xAccessor, displayXAccessor } = xScaleProvider(calculatedData.slice(-LENGTH_TO_SHOW));

        // console.log(head(linearData), last(linearData))
        // console.log(linearData.length)

        this.state = {
            ema26,
            ema12,
            macdCalculator,
            smaVolume50,
            linearData,
            data: linearData,
            xScale,
            xAccessor, displayXAccessor
        };
        this.handleDownloadMore = this.handleDownloadMore.bind(this);
    }
    handleDownloadMore(start, end) {
        if (Math.ceil(start) === end) return;
        // console.log("rows to download", rowsToDownload, start, end)
        const { data: prevData, ema26, ema12, macdCalculator, smaVolume50 } = this.state;
        const { data: inputData } = this.props;

        if (inputData.length === prevData.length) return;

        const rowsToDownload = end - Math.ceil(start);

        const maxWindowSize = getMaxUndefined([ema26,
            ema12,
            macdCalculator,
            smaVolume50
        ]);

        /* SERVER - START */
       
        //console.log("data recieved");
        const dataToCalculate = inputData
            .slice(-rowsToDownload - maxWindowSize - prevData.length, - prevData.length);

        const calculatedData = ema26(ema12(macdCalculator(smaVolume50(dataToCalculate))));
        const indexCalculator = discontinuousTimeScaleProviderBuilder()
            .initialIndex(Math.ceil(start))
            .indexCalculator();
        const { index } = indexCalculator(
            calculatedData
                .slice(-rowsToDownload)
                .concat(prevData));
        /* SERVER - END */

        const xScaleProvider = discontinuousTimeScaleProviderBuilder()
            .initialIndex(Math.ceil(start))
            .withIndex(index);

        const { data: linearData, xScale, xAccessor, displayXAccessor } = xScaleProvider(calculatedData.slice(-rowsToDownload).concat(prevData));

        this.setState({
            data: linearData,
            xScale,
            xAccessor,
            displayXAccessor,
        });
        
        //// console.log(linearData.length)
        //setTimeout(() => {
        //    // simulate a lag for ajax
        //    console.log("timeout");
            
        //}, 1000);

    }

    componentWillMount() {
        this.setState({
            suffix: 1
        });
    }

    saveNode(node) {
        this.node = node;
    }
    resetYDomain() {
        this.node.resetYDomain();
    }
    handleReset() {
        this.setState({
            suffix: this.state.suffix + 1
        });
    }

    render() {
        const { type, width, ratio, mouseMoveEvent, panEvent, zoomEvent, zoomAnchor, clamp } = this.props;
        const { data, ema26, ema12, macdCalculator, smaVolume50, xScale, xAccessor, displayXAccessor } = this.state;
        const chartHeight = 400;
        const margin = { left: 70, right: 70, top: 20, bottom: 30 };

        const start = xAccessor(last(data));
        const end = xAccessor(data[Math.max(0, data.length - 150)]);
        const xExtents = [start, end];


        const gridHeight = chartHeight - margin.top - margin.bottom;
        const gridWidth = width - margin.left - margin.right;

        const showGrid = true;
        const yGrid = showGrid ? { innerTickSize: -1 * gridWidth, tickStrokeOpacity: 0.2 } : {};
        const xGrid = showGrid ? { innerTickSize: -1 * gridHeight, tickStrokeOpacity: 0.2 } : {};


        return (
            <ChartCanvas ref={this.saveNode} ratio={ratio} width={width} height={chartHeight}
                margin={margin} type={type}
                data={data}
                xScale={xScale} xAccessor={xAccessor} displayXAccessor={displayXAccessor}
                onLoadMore={this.handleDownloadMore}
                mouseMoveEvent={mouseMoveEvent}
                panEvent={panEvent}
                zoomEvent={zoomEvent}
                clamp={clamp}
                zoomAnchor={zoomAnchor}
                type={type}
                xExtents={xExtents}
            >
                <Chart id={1} height={chartHeight - margin.top - margin.bottom}
                    yExtents={[d => [d.high, d.low], ema26.accessor(), ema12.accessor()]}
                    padding={{ top: 10, bottom: 20 }}>
                    <XAxis axisAt="bottom" orient="bottom" showTicks={true} outerTickSize={0} zoomEnabled={zoomEvent} {...xGrid} />
                    <YAxis axisAt="right" orient="right" ticks={5} zoomEnabled={zoomEvent} {...yGrid} />

                    <MouseCoordinateY
                        at="right"
                        orient="right"
                        displayFormat={format(".2f")} />

                    <CandlestickSeries />
                    {/*
                    <LineSeries yAccessor={ema26.accessor()} stroke={ema26.stroke()} />
                    <LineSeries yAccessor={ema12.accessor()} stroke={ema12.stroke()} />

                    <CurrentCoordinate yAccessor={ema26.accessor()} fill={ema26.stroke()} />
                    <CurrentCoordinate yAccessor={ema12.accessor()} fill={ema12.stroke()} />
                    */}
                    <EdgeIndicator itemType="last" orient="right" edgeAt="right"
                        yAccessor={d => d.close} fill={d => d.close > d.open ? "#6BA583" : "#FF0000"} />

                    <ZoomButtons
                        onReset={this.handleReset}
                    />

                    <OHLCTooltip origin={[-40, 0]} />
                    
                </Chart>
                <Chart id={2} height={150}
                    yExtents={[d => d.volume, smaVolume50.accessor()]}
                    origin={(w, h) => [0, h - 150]}>
                    <YAxis axisAt="left" orient="left" ticks={5} tickFormat={format(".2s")} zoomEnabled={zoomEvent}/>

                    <MouseCoordinateY
                        at="left"
                        orient="left"
                        displayFormat={format(".4s")} />
                    <MouseCoordinateX
                        at="bottom"
                        orient="bottom"
                        displayFormat={timeFormat("%Y-%m-%d")} />

                    <BarSeries yAccessor={d => d.volume} fill={d => d.close > d.open ? "#6BA583" : "#FF0000"} />
                    <AreaSeries yAccessor={smaVolume50.accessor()} stroke={smaVolume50.stroke()} fill={smaVolume50.fill()} />
                </Chart>
                {
                //<Chart id={3} height={150}
                //    yExtents={macdCalculator.accessor()}
                //    origin={(w, h) => [0, h - 150]} padding={{ top: 10, bottom: 10 }} >
                //    <XAxis axisAt="bottom" orient="bottom" />
                //    <YAxis axisAt="right" orient="right" ticks={2} />

                //    <MouseCoordinateX
                //        at="bottom"
                //        orient="bottom"
                //        displayFormat={timeFormat("%Y-%m-%d")} />
                //    <MouseCoordinateY
                //        at="right"
                //        orient="right"
                //        displayFormat={format(".2f")} />

                //    <MACDSeries yAccessor={d => d.macd}
                //        {...macdAppearance} />
                //    <MACDTooltip
                //        origin={[-38, 15]}
                //        yAccessor={d => d.macd}
                //        options={macdCalculator.options()}
                //        appearance={macdAppearance}
                //    />
                //</Chart>
                }
                <CrossHairCursor />
            </ChartCanvas>
        );
    }
}

/*

*/

CandleStickChartPanToLoadMore.propTypes = {
    data: PropTypes.array.isRequired,
    width: PropTypes.number.isRequired,
    ratio: PropTypes.number.isRequired,
    type: PropTypes.oneOf(["svg", "hybrid"]).isRequired,
};

CandleStickChartPanToLoadMore.defaultProps = {
    type: "svg",
};

CandleStickChartPanToLoadMore = fitWidth(CandleStickChartPanToLoadMore);

export default CandleStickChartPanToLoadMore;
