var webpack = require('webpack');

module.exports = {
    context: __dirname,
    entry: "./index.js",
    output: {
    path: __dirname + "/output",
    filename: "scripts.min.js"
    },
    plugins: [
        //new webpack.HotModuleReplacementPlugin(),
        //new webpack.NoErrorsPlugin(),
        //new webpack.IgnorePlugin(/^\.\/locale$/, /moment$/),
        //new webpack.DefinePlugin({
        //    'process.env': {
        //        // This has effect on the react lib size
        //        'NODE_ENV': JSON.stringify('production'),
        //    }
        //}),
        //new webpack.optimize.UglifyJsPlugin()

    //new webpack.optimize.DedupePlugin(),
    //new webpack.optimize.OccurenceOrderPlugin(),
    //new webpack.optimize.UglifyJsPlugin({ mangle: false, sourcemap: false }),
    ],
    module: {
        rules: [
            {
                test: /\.js$/,
                exclude: /node_modules/,
                use: {
                    loader: "babel-loader",
                    options: {
                        presets: ["@babel/preset-env", "@babel/preset-react"]
                    }
                }
            }
        ]
    }
};