
class Gateway
{
    constructor() { }

    doThingAsync(name) {
    return new Promise(function (resolve, reject) {
        window.myCalculator.calcAsync(name, resolve, reject);
    });


    OnUpdate(exchnageId, market, timeframe, append)
    {
        cSharpGateway.getOHLCVAsync(exchnageId, market, timeframe, null, 1000);
    }

}